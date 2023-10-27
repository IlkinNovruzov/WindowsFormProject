namespace ATM_ManagementSystem
{
    partial class Statement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            labelBack = new Label();
            guna2DataGridViewTr = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewTr).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 98);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(719, -15);
            label2.Name = "label2";
            label2.Size = new Size(43, 51);
            label2.TabIndex = 2;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(154, 22);
            label3.Name = "label3";
            label3.Size = new Size(490, 51);
            label3.TabIndex = 0;
            label3.Text = "ATM Management System";
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI Semibold", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.Location = new Point(344, 441);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(77, 38);
            labelBack.TabIndex = 23;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // guna2DataGridViewTr
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridViewTr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridViewTr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridViewTr.ColumnHeadersHeight = 4;
            guna2DataGridViewTr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridViewTr.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridViewTr.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewTr.Location = new Point(0, 97);
            guna2DataGridViewTr.Name = "guna2DataGridViewTr";
            guna2DataGridViewTr.RowHeadersVisible = false;
            guna2DataGridViewTr.RowHeadersWidth = 51;
            guna2DataGridViewTr.RowTemplate.Height = 29;
            guna2DataGridViewTr.Size = new Size(762, 303);
            guna2DataGridViewTr.TabIndex = 24;
            guna2DataGridViewTr.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridViewTr.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridViewTr.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridViewTr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridViewTr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridViewTr.ThemeStyle.BackColor = Color.White;
            guna2DataGridViewTr.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridViewTr.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridViewTr.ThemeStyle.ReadOnly = false;
            guna2DataGridViewTr.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridViewTr.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridViewTr.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridViewTr.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridViewTr.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridViewTr.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewTr.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2ButtonClear
            // 
            guna2ButtonClear.BorderRadius = 20;
            guna2ButtonClear.BorderThickness = 2;
            guna2ButtonClear.CustomizableEdges = customizableEdges1;
            guna2ButtonClear.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonClear.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonClear.FillColor = Color.Yellow;
            guna2ButtonClear.Font = new Font("Segoe UI Semibold", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ButtonClear.ForeColor = Color.Black;
            guna2ButtonClear.Location = new Point(519, 433);
            guna2ButtonClear.Margin = new Padding(0);
            guna2ButtonClear.Name = "guna2ButtonClear";
            guna2ButtonClear.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ButtonClear.Size = new Size(204, 46);
            guna2ButtonClear.TabIndex = 28;
            guna2ButtonClear.Text = "Clear History";
            guna2ButtonClear.Click += guna2ButtonClear_Click;
            // 
            // Statement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 488);
            Controls.Add(guna2ButtonClear);
            Controls.Add(guna2DataGridViewTr);
            Controls.Add(labelBack);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statement";
            Load += Statement_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewTr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label labelBack;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewTr;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonClear;
    }
}