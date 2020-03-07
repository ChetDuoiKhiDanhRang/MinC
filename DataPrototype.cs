using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinC
{
    public class DataPrototype : DataTable
    {
        internal DataColumn colBankName               = new DataColumn("BankName")
        {
            DataType                                  = typeof(string),
            Caption                                   = "Bank"
        };

        internal DataColumn colFinancialYear          = new DataColumn("FinancialYear")
        {
            DataType                                  = typeof(int),
            Caption                                   = "Financial Year"
        };

        internal DataColumn colTotalAssets            = new DataColumn("TotalAssets")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Total Assets"
        };

        internal DataColumn colEquity                 = new DataColumn("Equity")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Equity"
        };

        internal DataColumn colROA                    = new DataColumn("ROA")
        {
            DataType                                  = typeof(double),
            Caption                                   = "ROA"
        };

        internal DataColumn colNetProfitBeforeTax     = new DataColumn("NetProfitBeforeTax")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Net Profit Before Tax"
        };

        internal DataColumn colTotalExpense           = new DataColumn("TotalExpense")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Total Expense (C)"
        };

        internal DataColumn colInvestOnTech           = new DataColumn("InvestOnTech")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Invest On Tech"
        };


        internal DataColumn colCustomerDeposit        = new DataColumn("CustomerDeposit")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Customer Deposit"
        };

        internal DataColumn colExpenseOperatingIncome = new DataColumn("ExpenseOperatingIncome")
        {
            DataType                                  = typeof(double),
            Caption                                   = "Expense/OperatingIncome"
        };

        internal DataColumn colDividends = new DataColumn("Dividends")
        {
            DataType = typeof(double),
            Caption = "Dividends (Y)"
        };

        internal DataColumn colMarkerPriceOfRisk = new DataColumn("MarkerPriceOfRisk")
        {
            DataType = typeof(double),
            Caption = "Marker Price of Risk (κ)"
        };


        internal DataColumn colInterestRate = new DataColumn("InterestRate")
        {
            DataType = typeof(double),
            Caption = "Interest Rate (r)"
        };

        internal DataColumn colTotalValueByStock = new DataColumn("TotalValueByStock")
        {
            DataType = typeof(double),
            Caption = "Total Value by Stock"
        };

        internal DataColumn colInvestOnNewTree = new DataColumn("InvestOnNewTree")
        {
            DataType = typeof(double),
            Caption = "Invest on New Tree (i)"
        };

        internal DataColumn colZeta = new DataColumn("Zeta")
        {
            DataType = typeof(double),
            Caption = "ζ(i)"
        };

        public DataPrototype()
        {
            Columns.Add(colBankName);
            Columns.Add(colFinancialYear);
            Columns.Add(colTotalAssets);
            Columns.Add(colEquity);
            Columns.Add(colROA);
            Columns.Add(colNetProfitBeforeTax);
            Columns.Add(colTotalExpense);
            Columns.Add(colInvestOnTech);
            Columns.Add(colCustomerDeposit);
            Columns.Add(colExpenseOperatingIncome);
            Columns.Add(colDividends);
            Columns.Add(colMarkerPriceOfRisk);
            Columns.Add(colInterestRate);
            Columns.Add(colTotalValueByStock);
            Columns.Add(colInvestOnNewTree);
            Columns.Add(colZeta);
        }
    }
}
