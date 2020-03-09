using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvModelA.Columns["InvestOnTech"].DefaultCellStyle.Format      = "#,##0.00 $";
            dgvModelA.Columns["Dividends"].DefaultCellStyle.Format         = "#,##0.00 $";
            dgvModelA.Columns["MarkerPriceOfRisk"].DefaultCellStyle.Format = "#,##0.00 $";
            dgvModelA.Columns["InterestRate"].DefaultCellStyle.Format      = "0.00 %";
            dgvModelA.Columns["InvestOnNewTree"].DefaultCellStyle.Format   = "0.00 %";
            dgvModelA.Columns["Zeta"].DefaultCellStyle.Format              = "#,##0.00 $";
            dgvModelA.Columns["Theta"].DefaultCellStyle.Format             = "#,##0.00";
            dgvModelA.Columns["DeltaOfTheta"].DefaultCellStyle.Format      = "#,##0.00";
            dgvModelA.Columns["FK"].DefaultCellStyle.Format                = "0.00";

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
                double sumDeltaTheta = 0d;
                double sumDeltaOfThetaP2 = 0;
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
                if (count > 2)
                {
                    datatable.Rows.Clear();
                    for (int i = 0; i < count; i++)
                    {
                        var newRow = datatable.NewRow();
                        newRow["FinancialYear"] = datas[i]["FinancialYear"];
                        newRow["TotalAssets"] = datas[i]["TotalAssets"];
                        newRow["TotalExpense"] = datas[i]["TotalExpense"];
                        newRow["InvestOnTech"] = datas[i]["InvestOnTech"];
                        newRow["Dividends"] = datas[i]["Dividends"];
                        newRow["MarkerPriceOfRisk"] = datas[i]["MarkerPriceOfRisk"];
                        newRow["InterestRate"] = datas[i]["InterestRate"];
                        newRow["InvestOnNewTree"] = datas[i]["InvestOnNewTree"];
                        newRow["Zeta"] = datas[i]["Zeta"];
                        newRow["dHt"] = "-(" + Convert.ToString(Math.Round((double)datas[i]["InterestRate"], 2)) + "dt + " + Convert.ToString(Math.Round((double)datas[i]["MarkerPriceOfRisk"], 2)) +")";
                        if (i < count - 1)
                        {
                            newRow["Theta"] = (double)datas[i + 1]["Dividends"] / (double)newRow["Zeta"];
                            newRow["FK"] = ((double)newRow["TotalExpense"] / (double)newRow["Theta"]) - 1;
                            if (i > 0)
                            {
                                newRow["DeltaOfTheta"] = (double)newRow["Theta"] - (double)datatable.Rows[i - 1]["Theta"];
                                sumDeltaTheta += (double)newRow["DeltaOfTheta"];
                                sumDeltaOfThetaP2 += (double)newRow["DeltaOfTheta"] * (double)newRow["DeltaOfTheta"];
                            }
                        }

                        datatable.Rows.Add(newRow);
                    }
                }
                var mu = sumDeltaTheta / (count - 2);
                var sigma = Math.Sqrt(sumDeltaOfThetaP2 / (count - 2) - System.Math.Pow(2, mu));
                txbResult.Text = string.Format("RESULT:" + Environment.NewLine + " μ = {0:00.00}" + Environment.NewLine + " σ = {1:00.00}", mu, sigma);
                lblF1.Text = string.Format("{0:00.00}dt + {1:00.00}", mu, sigma);
                dgvModelA.AutoResizeColumns();
            }
        }
    }
}
