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
            MathMLFormulaControl.setFolderUrlForFonts(Application.StartupPath + @"\fonts");
            MathMLFormulaControl.setFolderUrlForGlyphs(Application.StartupPath + @"\glyphs");

            InitializeComponent();

            fm1.latex = true;
            fm1.Font = new System.Drawing.Font("Harlow Solid Italic", 6F,
                System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            String formular1 = "\\documentclass[12pt]\r\n" +
                "\\begin{document}\r\n" +
                "\\begin{equation}\\theta_{t} = x^2\\end{equation}\r\n" + 
                "\\end{document}\r\n";
            fm1.Contents = formular1;
            fm1.Invalidate();

            datatable = new DataModelA() { BankName = (string)cmbBank.SelectedItem };
            dgvModelA.DataSource = datatable;

            for (int i = 0; i < dgvModelA.ColumnCount; i++)
            {
                dgvModelA.Columns[i].HeaderText = datatable.Columns[i].Caption;
            }

            dgvModelA.Columns["FinancialYear"].DefaultCellStyle.Format = "###0";
            dgvModelA.Columns["TotalAssets"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["TotalExpense"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["InvestOnTech"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["Dividends"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["MarkerPriceOfRisk"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["InterestRate"].DefaultCellStyle.Format = "0.00 %";
            dgvModelA.Columns["InvestOnNewTree"].DefaultCellStyle.Format = "0.00 %";
            dgvModelA.Columns["Zeta"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["Theta"].DefaultCellStyle.Format = "#,##0.00";
            dgvModelA.Columns["DeltaOfTheta"].DefaultCellStyle.Format = "#,##0.00";
            dgvModelA.Columns["FK"].DefaultCellStyle.Format = "0.00";

        }

        private void FormModelA_Load(object sender, EventArgs e)
        {
            foreach (var item in frmMain.Banks)
            {
                cmbBank.Items.Add(item.Key);
            }



        }

        DataModelA datatable = new DataModelA();
        internal void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex >= 0)
            {
                string filter = "";
                filter = "BankName = '" + (string)cmbBank.SelectedItem + "'";
                switch (frmMain.cmbi.SelectedIndex)
                {
                    case 1:
                        filter += " AND InvestOnNewTree > '" + frmMain.nudFilterValue_i.Value.ToString() + "'";
                        break;
                    case 2:
                        filter += " AND InvestOnNewTree < '" + frmMain.nudFilterValue_i.Value.ToString() + "'";
                        break;
                    case 3:
                        filter += " AND InvestOnNewTree >= '" + frmMain.nudFilterValue_i.Value.ToString() + "'";
                        break;
                    case 4:
                        filter += " AND InvestOnNewTree <= '" + frmMain.nudFilterValue_i.Value.ToString() + "'";
                        break;
                    case 5:
                        filter += " AND InvestOnNewTree = '" + frmMain.nudFilterValue_i.Value.ToString() + "'";
                        break;
                    default:
                        break;
                }
                var datas = frmMain.BanksData.Select(filter, "FinancialYear ASC");
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
                            if (i > 0)
                            {
                                newRow["DeltaOfTheta"] = (double)newRow["Theta"] - (double)datatable.Rows[i - 1]["Theta"];
                            }
                        }

                        datatable.Rows.Add(newRow);
                    }
                }
            }
        }
    }
}
