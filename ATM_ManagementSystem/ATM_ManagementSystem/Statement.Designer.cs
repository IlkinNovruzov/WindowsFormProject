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
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            labelBack = new Label();
            panel2.SuspendLayout();
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
            labelBack.Location = new Point(343, 403);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(77, 38);
            labelBack.TabIndex = 23;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // Statement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 450);
            Controls.Add(labelBack);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label labelBack;
    }
}