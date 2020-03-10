using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using OfficeOpenXml;
namespace MinC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            Thread t = new Thread(new ThreadStart(() => Application.Run(new FormSplash())));
            t.Start();
            Thread.Sleep(3500);
            InitializeComponent();
            t.Abort();
            txbUser.Text = Properties.Settings.Default.LastUser;
            this.Activate();
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = txbUser.Text.Length > 0 && txbPassword.Text.Length > 0;
        }

        FormMain frmMain;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i = Login(txbUser.Text, txbPassword.Text);
            switch (i)
            {
                case -1:
                    MessageBox.Show("No user data!", "ERROR!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    MessageBox.Show("Wrong user or password!", "Login fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    frmMain = new FormMain("User: " + txbUser.Text);
                    frmMain.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private int Login(string username, string password)
        {
            int i = 0;
            //encrypt password
            byte[] b = UTF8Encoding.UTF8.GetBytes(password);
            string encrypt = Convert.ToBase64String(SHA512.Create().ComputeHash(b));

            //
            ExcelPackage user = new ExcelPackage(new System.IO.FileInfo(Application.StartupPath + @"\users"),
                "i3wUrCkiMRVqPcrUVBa8F+ujN6ycpYsFjibV8TjefbQMVHQ0sYxqJYpnv15BVaEEETL+0cyJdlylheftkHD8yQ==");
            if (user == null)
            {
                return -1;
            }
            var ws = user.Workbook.Worksheets[1];
            int count = ws.Dimension.Rows;
            if (count >= 2)
            {
                for (int n = 2; n <= count; n++)
                {
                    if (String.Equals(username, (string)ws.Cells[n, 1].Value, StringComparison.OrdinalIgnoreCase) &&
                        String.Equals(encrypt, (string)ws.Cells[n, 2].Value, StringComparison.Ordinal))
                    {
                        i += 1;
                    }
                }
            }
            return i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastUser = txbUser.Text;
            Properties.Settings.Default.Save();

        }

        private void txbUser_Enter(object sender, EventArgs e)
        {
            txbUser.SelectAll();
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            txbPassword.SelectAll();
        }

        int currenLocationX;
        int currenLocationY;
        bool onDrag = false;
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            onDrag = true;
            currenLocationX = e.X;
            currenLocationY = e.Y;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (onDrag)
            {
                int moveX = e.X;
                int moveY = e.Y;
                this.Location = new Point(this.Location.X + (e.X - currenLocationX), this.Location.Y + (e.Y - currenLocationY));
            }
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            onDrag = false;
        }
    }
}
