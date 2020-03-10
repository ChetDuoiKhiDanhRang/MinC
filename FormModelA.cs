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
            dgvModelA.MultiSelect = false;
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
            dgvModelA.Columns["a1"].Visible = false;
            dgvModelA.Columns["a2"].Visible = false;

        }

        private void FormModelA_Load(object sender, EventArgs e)
        {
            foreach (var item in frmMain.Banks)
            {
                cmbBank.Items.Add(item.Key);
            }
        }

        double muNetProfitBeforeTax;
        double sigmaProfitBeforeTax;

        double z1;
        double z2;

        DataModelA datatable = new DataModelA();
        internal void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = (cmbBank.SelectedIndex >= 0);
            if (cmbBank.SelectedIndex >= 0)
            {
                double sumDeltaTheta = 0d;
                double sumDeltaOfThetaP2 = 0;
                double sumProfitBeforeTax = 0;
                double sumProfitBeforeTaxP2 = 0;
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
                        newRow["Equity"] = datas[i]["Equity"];
                        newRow["TotalExpense"] = datas[i]["TotalExpense"];
                        newRow["InvestOnTech"] = datas[i]["InvestOnTech"];
                        newRow["Dividends"] = datas[i]["Dividends"];
                        newRow["MarkerPriceOfRisk"] = datas[i]["MarkerPriceOfRisk"];
                        newRow["InterestRate"] = datas[i]["InterestRate"];
                        newRow["InvestOnNewTree"] = datas[i]["InvestOnNewTree"];
                        newRow["Zeta"] = datas[i]["Zeta"];
                        newRow["dHt"] = "-(" + ((double)datas[i]["InterestRate"]).ToString() +
                            "dt + " +
                            ((double)datas[i]["MarkerPriceOfRisk"]).ToString() + ")";
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
                        var a1 = Math.Round((double)datas[i]["TotalAssets"] * (double)datas[i]["InterestRate"], 2);
                        var a2 = Math.Round((double)datas[i]["TotalAssets"] * (double)datas[i]["MarkerPriceOfRisk"], 2);
                        newRow["a1"] = a1;
                        newRow["a2"] = a2;

                        newRow["Asup"] = a1.ToString("00.00") + "dt +" + a2.ToString("00.00");

                        datatable.Rows.Add(newRow);

                        sumProfitBeforeTax += (double)datas[i]["NetProfitBeforeTax"];
                        sumProfitBeforeTaxP2 += (double)datas[i]["NetProfitBeforeTax"] * (double)datas[i]["NetProfitBeforeTax"];
                        muNetProfitBeforeTax = sumProfitBeforeTax / count;
                        sigmaProfitBeforeTax = Math.Sqrt((sumProfitBeforeTaxP2 / count) - muNetProfitBeforeTax);
                    }
                }

                //show Theta's result
                var muDeltaTheta = sumDeltaTheta / (count - 2);
                var DeltaTheta = Math.Sqrt(sumDeltaOfThetaP2 / (count - 2) - System.Math.Pow(2, muDeltaTheta));
                txbResultA.Text = string.Format("RESULT (ΔΘ):" + Environment.NewLine + " μ = {0:00.00}" + Environment.NewLine + " σ = {1:00.00}", muDeltaTheta, DeltaTheta);
                lblF1.Text = string.Format("{0:00.00}dt + {1:00.00}", muDeltaTheta, DeltaTheta);

                //show Net Profit Before Tax's result
                txbResultB.Text = string.Format("RESULT (Net Profit Before Tax):" + Environment.NewLine + " μ = {0:00.00}" + Environment.NewLine + " σ = {1:00.00}",
                    muNetProfitBeforeTax, sigmaProfitBeforeTax);

                z1 = muNetProfitBeforeTax / sigmaProfitBeforeTax;

                foreach (DataRow row in datatable.Rows)
                {
                    row["Z"] = z1.ToString("00.00") + " + " + ((double)row["Equity"] / sigmaProfitBeforeTax).ToString("0.00") + "/(" + (string)row["Asup"] + " )";
                }
                dgvModelA.AutoResizeColumns();

            }
        }

        private void dgvModelA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvModelA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvModelA_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModelA.Rows.Count <= 0)
            {
                return;
            }

        }

        private void dgvModelA_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModelA.SelectedRows.Count == 1 && dgvModelA.SelectedRows[0].Index > 0)
            {
                label3.Text = (string)dgvModelA.SelectedRows[0].Cells["Z"].Value;
                double equity = (double)dgvModelA.SelectedRows[0].Cells["Equity"].Value;

                double a1 = (double)dgvModelA.SelectedRows[0].Cells["a1"].Value;
                double a2 = (double)dgvModelA.SelectedRows[0].Cells["a2"].Value;

                double z2 = equity / sigmaProfitBeforeTax;
                double z = z1 + z2/(a1 * (double)nuddt.Value + a2);
                lblz.Text = "z = " + z.ToString() + ((z >= (double)nudMinZ.Value && z <= (double)nudMaxZ.Value)? "    (Approve)": "    (Reject)");
                lblz.ForeColor = (z >= (double)nudMinZ.Value && z <= (double)nudMaxZ.Value)? Color.Navy:Color.DarkRed;
            }
        }
    }
}
