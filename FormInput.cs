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
    public partial class FormInput : Form
    {
        public FormInput(FormMain formMain)
        {
            InitializeComponent();
            myParent = formMain;
        }

        FormMain myParent;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void txbTech_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = txbTech.Text.Trim().Length > 0;
        }
    }
}
