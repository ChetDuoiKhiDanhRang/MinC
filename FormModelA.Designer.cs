namespace MinC
{
    partial class FormModelA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblF1 = new System.Windows.Forms.Label();
            this.dgvModelA = new System.Windows.Forms.DataGridView();
            this.txbResultA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbResultB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinZ = new System.Windows.Forms.NumericUpDown();
            this.nudMaxZ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nuddt = new System.Windows.Forms.NumericUpDown();
            this.lblz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuddt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(55, 28);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(93, 21);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            // 
            // lblF1
            // 
            this.lblF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblF1.AutoSize = true;
            this.lblF1.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF1.Location = new System.Drawing.Point(139, 335);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(17, 17);
            this.lblF1.TabIndex = 2;
            this.lblF1.Text = "...";
            // 
            // dgvModelA
            // 
            this.dgvModelA.AllowUserToAddRows = false;
            this.dgvModelA.AllowUserToDeleteRows = false;
            this.dgvModelA.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvModelA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModelA.BackgroundColor = System.Drawing.Color.White;
            this.dgvModelA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModelA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelA.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModelA.Location = new System.Drawing.Point(11, 70);
            this.dgvModelA.Name = "dgvModelA";
            this.dgvModelA.ReadOnly = true;
            this.dgvModelA.RowHeadersVisible = false;
            this.dgvModelA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelA.Size = new System.Drawing.Size(824, 171);
            this.dgvModelA.TabIndex = 7;
            this.dgvModelA.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelA_CellEnter);
            this.dgvModelA.SelectionChanged += new System.EventHandler(this.dgvModelA_SelectionChanged);
            // 
            // txbResultA
            // 
            this.txbResultA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResultA.Font = new System.Drawing.Font("Consolas", 11F);
            this.txbResultA.Location = new System.Drawing.Point(11, 247);
            this.txbResultA.Multiline = true;
            this.txbResultA.Name = "txbResultA";
            this.txbResultA.ReadOnly = true;
            this.txbResultA.Size = new System.Drawing.Size(824, 68);
            this.txbResultA.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(11, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(824, 2);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // txbResultB
            // 
            this.txbResultB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResultB.Font = new System.Drawing.Font("Consolas", 11F);
            this.txbResultB.Location = new System.Drawing.Point(11, 402);
            this.txbResultB.Multiline = true;
            this.txbResultB.Name = "txbResultB";
            this.txbResultB.ReadOnly = true;
            this.txbResultB.Size = new System.Drawing.Size(824, 68);
            this.txbResultB.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::MinC.Properties.Resources.FB;
            this.pictureBox3.Location = new System.Drawing.Point(11, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::MinC.Properties.Resources.f2;
            this.pictureBox2.Location = new System.Drawing.Point(11, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MinC.Properties.Resources.f1;
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "...";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Condition:";
            // 
            // nudMinZ
            // 
            this.nudMinZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMinZ.DecimalPlaces = 3;
            this.nudMinZ.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudMinZ.Location = new System.Drawing.Point(441, 546);
            this.nudMinZ.Name = "nudMinZ";
            this.nudMinZ.Size = new System.Drawing.Size(65, 25);
            this.nudMinZ.TabIndex = 11;
            this.nudMinZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinZ.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudMinZ.ValueChanged += new System.EventHandler(this.dgvModelA_SelectionChanged);
            // 
            // nudMaxZ
            // 
            this.nudMaxZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMaxZ.DecimalPlaces = 3;
            this.nudMaxZ.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudMaxZ.Location = new System.Drawing.Point(545, 546);
            this.nudMaxZ.Name = "nudMaxZ";
            this.nudMaxZ.Size = new System.Drawing.Size(65, 25);
            this.nudMaxZ.TabIndex = 11;
            this.nudMaxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxZ.Value = new decimal(new int[] {
            159,
            0,
            0,
            131072});
            this.nudMaxZ.ValueChanged += new System.EventHandler(this.dgvModelA_SelectionChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "≤ z ≤";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Let dt = ";
            // 
            // nuddt
            // 
            this.nuddt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuddt.DecimalPlaces = 2;
            this.nuddt.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuddt.Location = new System.Drawing.Point(185, 546);
            this.nuddt.Name = "nuddt";
            this.nuddt.Size = new System.Drawing.Size(65, 25);
            this.nuddt.TabIndex = 11;
            this.nuddt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuddt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuddt.ValueChanged += new System.EventHandler(this.dgvModelA_SelectionChanged);
            // 
            // lblz
            // 
            this.lblz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblz.AutoSize = true;
            this.lblz.Font = new System.Drawing.Font("Cambria", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblz.Location = new System.Drawing.Point(126, 591);
            this.lblz.Name = "lblz";
            this.lblz.Size = new System.Drawing.Size(30, 17);
            this.lblz.TabIndex = 2;
            this.lblz.Text = "z = ";
            // 
            // FormModelA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 618);
            this.Controls.Add(this.nudMaxZ);
            this.Controls.Add(this.nuddt);
            this.Controls.Add(this.nudMinZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbResultB);
            this.Controls.Add(this.txbResultA);
            this.Controls.Add(this.dgvModelA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblF1);
            this.Controls.Add(this.cmbBank);
            this.Name = "FormModelA";
            this.ShowIcon = false;
            this.Text = "DSS";
            this.Load += new System.EventHandler(this.FormModelA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuddt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.DataGridView dgvModelA;
        private System.Windows.Forms.TextBox txbResultA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txbResultB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinZ;
        private System.Windows.Forms.NumericUpDown nudMaxZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuddt;
        private System.Windows.Forms.Label lblz;
    }
}