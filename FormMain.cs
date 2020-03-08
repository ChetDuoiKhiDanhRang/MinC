using OfficeOpenXml;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MinC
{
    public partial class FormMain : Form
    {
        public event EventHandler<string> DataFileChanged;
        public event EventHandler<DataPrototype> DataTableChanged;
        public event EventHandler<string> StringFilterChanged;
        public FormMain()
        {
            InitializeComponent();


            BanksData = new DataPrototype();
            dgvData.DataSource = BanksData;
            dgvData.Columns[2].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[3].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[4].DefaultCellStyle.Format = "0.00 %";
            dgvData.Columns[5].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[6].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[7].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[8].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns[9].DefaultCellStyle.Format = "0.00%";
            dgvData.Columns["MarkerPriceOfRisk"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns["InterestRate"].DefaultCellStyle.Format = "0.00 %";
            dgvData.Columns["TotalValueByStock"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.Columns["InvestOnNewTree"].DefaultCellStyle.Format = "0.00 %";
            dgvData.Columns["Zeta"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            int count = BanksData.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dgvData.Columns[i].HeaderText = BanksData.Columns[i].Caption;
            }

            DataFileChanged += FormMain_DataFileChanged;
            StringFilterChanged += FormMain_StringFilterChanged;

            cmbi.SelectedIndex = 0;
            cmbi.FormatString = "0.00%";
        }





        internal Dictionary<string, string> Banks = new Dictionary<string, string>();



        FormModelB frmModelB;
        private void btnModelB_Click(object sender, EventArgs e)
        {
            if (frmModelB == null || frmModelB.IsDisposed)
            {
                frmModelB = new FormModelB();
                frmModelB.Show();
            }
        }


        FormModelA frmModelA;
        private void btnModelA_Click(object sender, EventArgs e)
        {
            if (frmModelA == null || frmModelA.IsDisposed)
            {
                frmModelA = new FormModelA();
                frmModelA.frmMain = this;
                frmModelA.Show();
            }
        }
        
        //open file
        string currentFile;
        private void lblDataFile_Click(object sender, EventArgs e)
        {
            if (frmModelA != null)
            {
                frmModelA.Close();
            }

            if (frmModelB != null)
            {
                frmModelB.Close();
            }

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

        //read data from file
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
            Banks.Clear();
            foreach (var sheet in DataFile.Workbook.Worksheets)
            {
                string bankName = sheet.Name;
                Banks.Add(bankName, "");
                if (sheet.Dimension == null || sheet.Dimension.Columns < BanksData.Columns.Count - 1)
                {
                    continue;
                }
                for (int row = 2; row <= sheet.Dimension.Rows; row++)
                {
                    var nr = BanksData.NewRow();
                    nr[0] = bankName;
                    for (int column = 0; column < BanksData.Columns.Count; column++)
                    {
                        int n = sheet.Dimension.Columns;
                        if (sheet.Cells[row, column + 1].Value != null)
                        {
                            nr[column + 1] = sheet.Cells[row, column + 1].Value;
                        }
                    }
                    BanksData.Rows.Add(nr);
                }
            }
            BanksData.DefaultView.Sort = "BankName ASC, FinancialYear ASC";
            dgvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //filter data
        string stringFilter;
        public string StringFilter
        {
            get => stringFilter;
            set
            {
                stringFilter = value;
                StringFilterChanged?.Invoke(this, stringFilter);
            }
        }
        private string FilterBuilder()
        {
            string s = "";

            if (cmbBank.SelectedIndex <= 0)
            {
                dgvData.Columns[0].Visible = true;
                s = "1=1";
            }
            else
            {
                dgvData.Columns[0].Visible = false;
                s = "BankName = '" + (string)cmbBank.SelectedItem + "'";
            }

            switch (cmbi.SelectedIndex)
            {
                case 1:
                    s += " AND InvestOnNewTree > '" + nudFilterValue_i.Value.ToString() + "'";
                    break;
                case 2:
                    s += " AND InvestOnNewTree < '" + nudFilterValue_i.Value.ToString() + "'";
                    break;
                case 3:
                    s += " AND InvestOnNewTree >= '" + nudFilterValue_i.Value.ToString() + "'";
                    break;
                case 4:
                    s += " AND InvestOnNewTree <= '" + nudFilterValue_i.Value.ToString() + "'";
                    break;
                case 5:
                    s += " AND InvestOnNewTree = '" + nudFilterValue_i.Value.ToString() + "'";
                    break;
                default:
                    break;
            }
            return s;
        }
        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringFilter = FilterBuilder();
            if (frmModelA != null && !frmModelA.IsDisposed)
            {
                frmModelA.cmbBank_SelectedIndexChanged(this, null);
            }
        }
        private void cmbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudFilterValue_i.Enabled = (cmbi.SelectedIndex > 0);
            StringFilter = FilterBuilder();
            if (frmModelA != null && !frmModelA.IsDisposed)
            {
                frmModelA.cmbBank_SelectedIndexChanged(this, null);
            }
        }
        private void nudFilterValue_i_ValueChanged(object sender, EventArgs e)
        {
            StringFilter = FilterBuilder();
            if (frmModelA != null && !frmModelA.IsDisposed)
            {
                frmModelA.cmbBank_SelectedIndexChanged(this, null);
            }
        }
        private void FormMain_StringFilterChanged(object sender, string e)
        {
            if (BanksData != null)
            {
                BanksData.DefaultView.RowFilter = StringFilter;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BanksData.DefaultView.Sort);
        }

    }
}