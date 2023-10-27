namespace ATM_ManagementSystem
{
    partial class Deposit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            guna2TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ButtonDeposit = new Guna.UI2.WinForms.Guna2Button();
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
            panel2.Size = new Size(588, 98);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(544, -13);
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
            label3.Location = new Point(48, 19);
            label3.Name = "label3";
            label3.Size = new Size(490, 51);
            label3.TabIndex = 0;
            label3.Text = "ATM Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 199);
            label1.Name = "label1";
            label1.Size = new Size(178, 51);
            label1.TabIndex = 6;
            label1.Text = "Amount:";
            // 
            // guna2TextBoxUsername
            // 
            guna2TextBoxUsername.BorderColor = Color.Black;
            guna2TextBoxUsername.BorderRadius = 5;
            guna2TextBoxUsername.BorderThickness = 2;
            guna2TextBoxUsername.CustomizableEdges = customizableEdges1;
            guna2TextBoxUsername.DefaultText = "";
            guna2TextBoxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBoxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBoxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBoxUsername.ForeColor = Color.Black;
            guna2TextBoxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxUsername.Location = new Point(252, 204);
            guna2TextBoxUsername.Margin = new Padding(3, 4, 3, 4);
            guna2TextBoxUsername.Name = "guna2TextBoxUsername";
            guna2TextBoxUsername.PasswordChar = '\0';
            guna2TextBoxUsername.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            guna2TextBoxUsername.PlaceholderText = "";
            guna2TextBoxUsername.SelectedText = "";
            guna2TextBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBoxUsername.Size = new Size(198, 46);
            guna2TextBoxUsername.TabIndex = 7;
            // 
            // guna2ButtonDeposit
            // 
            guna2ButtonDeposit.BorderRadius = 20;
            guna2ButtonDeposit.BorderThickness = 2;
            guna2ButtonDeposit.CustomizableEdges = customizableEdges3;
            guna2ButtonDeposit.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonDeposit.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonDeposit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonDeposit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonDeposit.FillColor = Color.Yellow;
            guna2ButtonDeposit.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ButtonDeposit.ForeColor = Color.Black;
            guna2ButtonDeposit.Location = new Point(144, 332);
            guna2ButtonDeposit.Name = "guna2ButtonDeposit";
            guna2ButtonDeposit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ButtonDeposit.Size = new Size(271, 66);
            guna2ButtonDeposit.TabIndex = 23;
            guna2ButtonDeposit.Text = "Deposit";
            guna2ButtonDeposit.Click += guna2ButtonDeposit_Click;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI Semibold", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.Location = new Point(239, 403);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(77, 38);
            labelBack.TabIndex = 24;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(labelBack);
            Controls.Add(guna2ButtonDeposit);
            Controls.Add(guna2TextBoxUsername);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUsername;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeposit;
        private Label labelBack;
    }
}