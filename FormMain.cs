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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        FormBankStabibity frmBankStability;
        private void btnBankStability_Click(object sender, EventArgs e)
        {
            if (frmBankStability==null||frmBankStability.IsDisposed)
            {
                frmBankStability = new FormBankStabibity();
                frmBankStability.Show();
            }
        }
    }
}
