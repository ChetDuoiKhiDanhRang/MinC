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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModelA = new System.Windows.Forms.DataGridView();
            this.fm1 = new fmath.controls.MathMLFormulaControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelA)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(55, 12);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(93, 21);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank:";
            // 
            // dgvModelA
            // 
            this.dgvModelA.AllowUserToAddRows = false;
            this.dgvModelA.AllowUserToDeleteRows = false;
            this.dgvModelA.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvModelA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvModelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModelA.BackgroundColor = System.Drawing.Color.White;
            this.dgvModelA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvModelA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModelA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvModelA.Location = new System.Drawing.Point(12, 39);
            this.dgvModelA.Name = "dgvModelA";
            this.dgvModelA.ReadOnly = true;
            this.dgvModelA.RowHeadersVisible = false;
            this.dgvModelA.Size = new System.Drawing.Size(776, 229);
            this.dgvModelA.TabIndex = 7;
            // 
            // fm1
            // 
            this.fm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fm1.Contents = "<math><mtext>\\theta</mtext></math>";
            this.fm1.Location = new System.Drawing.Point(14, 283);
            this.fm1.Name = "fm1";
            this.fm1.Size = new System.Drawing.Size(773, 53);
            this.fm1.TabIndex = 8;
            // 
            // FormModelA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fm1);
            this.Controls.Add(this.dgvModelA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBank);
            this.Name = "FormModelA";
            this.Text = "FormModelA";
            this.Load += new System.EventHandler(this.FormModelA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModelA;
        private fmath.controls.MathMLFormulaControl fm1;
    }
}