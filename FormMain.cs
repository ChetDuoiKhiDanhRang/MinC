using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Packaging;

namespace MinC
{
    public partial class FormMain : Form
    {
        public event EventHandler<string> DataFileChanged;
        public event EventHandler<DataPrototype> DataTableChanged;
        public FormMain()
        {
            InitializeComponent();

            BanksData = new DataPrototype();
            dgvData.DataSource = BanksData;
            dgvData.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[3].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[4].DefaultCellStyle.Format = "0.00%";
            dgvData.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[7].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[8].DefaultCellStyle.Format = "#,##0.00";
            dgvData.Columns[9].DefaultCellStyle.Format = "0.00%";
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            int count = BanksData.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dgvData.Columns[i].HeaderText = BanksData.Columns[i].Caption;
            }

            DataFileChanged += FormMain_DataFileChanged;
        }

        DataPrototype banksData;
        public DataPrototype BanksData
        {
            get => banksData;
            set
            {
                banksData = value;
                DataTableChanged?.Invoke(this, banksData);
            }
        }

        private void FormMain_DataFileChanged(object sender, string e)
        {

            lblFileLocation.Visible = (dataFile != null);
            lblFileLocation.Text = e.Substring(e.IndexOf('('), e.Length - e.IndexOf('('));
            textBox1.Text = e.Substring(0, e.IndexOf('('));

            //add banks to combobox
            cmbBank.Items.Clear();
            if (DataFile.Workbook.Worksheets.Count == 0)
            {
                MessageBox.Show("There is no sheet in selected file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbBank.Items.Add("ALL");
            foreach (var item in DataFile.Workbook.Worksheets)
            {
                cmbBank.Items.Add(item.Name);
            }
            cmbBank.SelectedIndex = 0;

            BanksData.Rows.Clear();
            foreach (var sheet in DataFile.Workbook.Worksheets)
            {
                string bankName = sheet.Name;
                if (sheet.Dimension==null)
                {
                    continue;
                }
                for (int i = 1; i < sheet.Dimension.Rows; i++)
                {
                    var nr = BanksData.NewRow();
                    nr[0] = bankName;
                    for (int j = 0; j < BanksData.Columns.Count; j++)
                    {
                        if (sheet.Cells[i + 1, j + 1].Value != null)
                        {
                            nr[j + 1] = sheet.Cells[i + 1, j + 1].Value;
                        }
                    }
                    BanksData.Rows.Add(nr);
                }
            }
            dgvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
            
        }

        ExcelPackage dataFile;
        public ExcelPackage DataFile
        {
            get => dataFile;
            set
            {
                dataFile = value;
                var e = dataFile.File.Name + "(" + dataFile.File.DirectoryName + ")";
                DataFileChanged?.Invoke(this, e);
            }
        }


        FormBankStabibity frmBankStability;


        private void btnModelB_Click(object sender, EventArgs e)
        {
            if (frmBankStability == null || frmBankStability.IsDisposed)
            {
                frmBankStability = new FormBankStabibity();
                frmBankStability.Show();
            }
        }


        string currentFile;
        private void lblDataFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Excel file|*.xlsx; *.xlsm",
                Multiselect = false,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFile = ofd.FileName;
                DataFile = new ExcelPackage(new System.IO.FileInfo(currentFile));
            }
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex < 0)
            {
                return;
            }
            else if (cmbBank.SelectedIndex == 0)
            {
                dgvData.Columns[0].Visible = true;
                BanksData.DefaultView.RowFilter = "1=1";
            }
            else
            {
                dgvData.Columns[0].Visible = false;

                string s = (string)cmbBank.SelectedItem;
                BanksData.DefaultView.RowFilter = "BankName = '" + s + "'";
            }
        }

        private void btnModelA_Click(object sender, EventArgs e)
        {

        }
    }
}
