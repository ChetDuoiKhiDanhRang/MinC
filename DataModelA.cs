using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinC
{
    class DataModelA:DataTable
    {
        public string BankName { get; set; }

        internal DataColumn colFinancialYear = new DataColumn("FinancialYear")
        {
            DataType = typeof(int),
            Caption = "Financial Year"
        };

        internal DataColumn colTotalAssets = new DataColumn("TotalAssets")
        {
            DataType = typeof(double),
            Caption = "Total Assets"
        };

        internal DataColumn colEquity = new DataColumn("Equity")
        {
            DataType = typeof(double),
            Caption = "Equity"
        };

        internal DataColumn colTotalExpense = new DataColumn("TotalExpense")
        {
            DataType = typeof(double),
            Caption = "Total Expense (C)"
        };

        internal DataColumn colInvestOnTech = new DataColumn("InvestOnTech")
        {
            DataType = typeof(double),
            Caption = "Invest On Tech"
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

        internal DataColumn colTheta = new DataColumn("Theta")
        {
            DataType = typeof(double),
            Caption = "θ"
        };

        internal DataColumn colDeltaTheta = new DataColumn("DeltaOfTheta")
        {
            DataType = typeof(double),
            Caption = "Δθ"
        };

        internal DataColumn colFK = new DataColumn("FK")
        {
            DataType = typeof(double),
            Caption = "F(K)"
        };

        internal DataColumn coldHt = new DataColumn("dHt")
        {
            DataType = typeof(string),
            Caption = "dHt/Ht"
        };

        internal DataColumn cola1 = new DataColumn("a1")
        {
            DataType = typeof(double),
            Caption = "a1"
        };

        internal DataColumn cola2 = new DataColumn("a2")
        {
            DataType = typeof(double),
            Caption = "a2"
        };

        internal DataColumn colAsup = new DataColumn("Asup")
        {
            DataType = typeof(string),
            Caption = "A^"
        };

        internal DataColumn colZ = new DataColumn("Z")
        {
            DataType = typeof(string),
            Caption = "z"
        };

        public DataModelA()
        {
            Columns.Add(colFinancialYear);

            Columns.Add(colInvestOnTech);
            Columns.Add(colDividends);
            Columns.Add(colTotalAssets);
            Columns.Add(colEquity);
            Columns.Add(colTotalExpense);                                           
            Columns.Add(colMarkerPriceOfRisk);
            Columns.Add(colInterestRate);
            Columns.Add(colInvestOnNewTree);
            Columns.Add(colZeta);
            Columns.Add(colTheta);
            Columns.Add(colFK);
            Columns.Add(colDeltaTheta);
            Columns.Add(coldHt);
            Columns.Add(cola1);
            Columns.Add(cola2);
            Columns.Add(colAsup);
            Columns.Add(colZ);
        }

    }
}
