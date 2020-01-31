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
        public FormMain()
        {
            InitializeComponent();
            DataFileChanged += FormMain_DataFileChanged;
        }

        private void FormMain_DataFileChanged(object sender, string e)
        {
            label1.Visible = (dataFile != null);
            label1.Text = e.Substring(e.IndexOf('('), e.Length-e.IndexOf('('));
            textBox1.Text = e.Substring(0, e.IndexOf('('));
        }

        ExcelPackage dataFile;
        public ExcelPackage DataFile
        {
            get => dataFile;
            set
            {
                dataFile = value;
                if (dataFile != null)
                {
                    var e = dataFile.File.Name + "(" + dataFile.File.DirectoryName + ")";
                    DataFileChanged?.Invoke(this, e);
                }
            }
        }


        FormBankStabibity frmBankStability;


        private void btnBankStability_Click(object sender, EventArgs e)
        {
            if (frmBankStability == null || frmBankStability.IsDisposed)
            {
                frmBankStability = new FormBankStabibity();
                frmBankStability.Show();
            }
        }


        private void btnSelectData_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Excel file|*.xlsx; *.xlsm",
                Multiselect = false,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataFile = new ExcelPackage(new System.IO.FileInfo(ofd.FileName));
            }
        }
    }
}
