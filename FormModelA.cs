using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fmath.controls;

namespace MinC
{
    public partial class FormModelA : Form
    {
        internal FormMain frmMain;
        public FormModelA()
        {
            InitializeComponent();

            datatable = new DataModelA() { BankName = (string)cmbBank.SelectedItem };
            dgvModelA.DataSource = datatable;

            for (int i = 0; i < dgvModelA.ColumnCount; i++)
            {
                dgvModelA.Columns[i].HeaderText = datatable.Columns[i].Caption;
            }

            dgvModelA.Columns["FinancialYear"].DefaultCellStyle.Format     = "###0";
            dgvModelA.Columns["TotalAssets"].DefaultCellStyle.Format       = "#,##0.00 $";
            dgvModelA.Columns["TotalExpense"].DefaultCellStyle.Format      = "#,##0.00 $";
            dgvModelA.Columns["Dividends"].DefaultCellStyle.Format         = "#,##0.00 $";
            dgvModelA.Columns["MarkerPriceOfRisk"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["InterestRate"].DefaultCellStyle.Format      = "0.00 %";
            dgvModelA.Columns["InvestOnNewTree"].DefaultCellStyle.Format   = "0.00 %";
            dgvModelA.Columns["Zeta"].DefaultCellStyle.Format              = "0.00 %";
            dgvModelA.Columns["Theta"].DefaultCellStyle.Format   = "#,##0.00 $";
            dgvModelA.Columns["FK"].DefaultCellStyle.Format   = "0.00 %";

            MathMLFormulaControl.setFolderUrlForFonts(Application.StartupPath + @"\fonts");
            MathMLFormulaControl.setFolderUrlForGlyphs(Application.StartupPath + @"\glyphs");
        }

        private void FormModelA_Load(object sender, EventArgs e)
        {
            foreach (var item in frmMain.Banks)
            {
                cmbBank.Items.Add(item.Key);
            }
        }

        DataModelA datatable = new DataModelA();
        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex >= 0)
            {
                var datas = frmMain.BanksData.Select("BankName = '" + (string)cmbBank.SelectedItem + "'", "FinancialYear ASC");
                int count = datas.Count();
                if (count > 0)
                {
                    datatable.Rows.Clear();
                    for (int i = 0; i < count; i++)
                    {
                        var newRow = datatable.NewRow();
                        newRow["FinancialYear"] = datas[i]["FinancialYear"];
                        newRow["TotalAssets"] = datas[i]["TotalAssets"];
                        newRow["TotalExpense"] = datas[i]["TotalExpense"];
                        newRow["Dividends"] = datas[i]["Dividends"];
                        newRow["MarkerPriceOfRisk"] = datas[i]["MarkerPriceOfRisk"];
                        newRow["InterestRate"] = datas[i]["InterestRate"];
                        newRow["InvestOnNewTree"] = datas[i]["InvestOnNewTree"];
                        newRow["Zeta"] = datas[i]["Zeta"];
                        if (i < count - 1)
                        {
                            newRow["Theta"] = (double)datas[i + 1]["Dividends"] / (double)newRow["Zeta"];
                            newRow["FK"] = ((double)newRow["TotalExpense"] / (double)newRow["Theta"]) - 1;
                        }
                        datatable.Rows.Add(newRow);
                    }
                }
            }
        }
    }
}
