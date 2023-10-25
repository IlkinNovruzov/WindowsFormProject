namespace ATM_ManagementSystem
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            labelExit = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBoxPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            guna2ButtonSignUp = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 19);
            label1.Name = "label1";
            label1.Size = new Size(490, 51);
            label1.TabIndex = 0;
            label1.Text = "ATM Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(labelExit);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 100);
            panel1.TabIndex = 1;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelExit.Location = new Point(870, -13);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(43, 51);
            labelExit.TabIndex = 2;
            labelExit.Text = "x";
            labelExit.Click += labelExit_Click;
            // 
            // guna2TextBoxUsername
            // 
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
            guna2TextBoxUsername.Location = new Point(425, 182);
            guna2TextBoxUsername.Margin = new Padding(3, 4, 3, 4);
            guna2TextBoxUsername.Name = "guna2TextBoxUsername";
            guna2TextBoxUsername.PasswordChar = '\0';
            guna2TextBoxUsername.PlaceholderText = "";
            guna2TextBoxUsername.SelectedText = "";
            guna2TextBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBoxUsername.Size = new Size(286, 46);
            guna2TextBoxUsername.TabIndex = 5;
            // 
            // guna2TextBoxPinCode
            // 
            guna2TextBoxPinCode.CustomizableEdges = customizableEdges3;
            guna2TextBoxPinCode.DefaultText = "";
            guna2TextBoxPinCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBoxPinCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBoxPinCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxPinCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxPinCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxPinCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBoxPinCode.ForeColor = Color.Black;
            guna2TextBoxPinCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxPinCode.Location = new Point(425, 251);
            guna2TextBoxPinCode.Margin = new Padding(3, 4, 3, 4);
            guna2TextBoxPinCode.Name = "guna2TextBoxPinCode";
            guna2TextBoxPinCode.PasswordChar = '\0';
            guna2TextBoxPinCode.PlaceholderText = "";
            guna2TextBoxPinCode.SelectedText = "";
            guna2TextBoxPinCode.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBoxPinCode.Size = new Size(286, 44);
            guna2TextBoxPinCode.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(386, 102);
            label2.Name = "label2";
            label2.Size = new Size(122, 51);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // guna2ButtonLogin
            // 
            guna2ButtonLogin.BorderRadius = 20;
            guna2ButtonLogin.BorderThickness = 2;
            guna2ButtonLogin.CustomizableEdges = customizableEdges5;
            guna2ButtonLogin.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonLogin.FillColor = Color.Yellow;
            guna2ButtonLogin.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ButtonLogin.ForeColor = Color.Black;
            guna2ButtonLogin.Location = new Point(332, 316);
            guna2ButtonLogin.Name = "guna2ButtonLogin";
            guna2ButtonLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ButtonLogin.Size = new Size(225, 56);
            guna2ButtonLogin.TabIndex = 8;
            guna2ButtonLogin.Text = "Login";
            guna2ButtonLogin.Click += guna2ButtonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(180, 248);
            label3.Name = "label3";
            label3.Size = new Size(162, 47);
            label3.TabIndex = 9;
            label3.Text = "Pin Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(180, 181);
            label4.Name = "label4";
            label4.Size = new Size(180, 47);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(341, 385);
            label5.Name = "label5";
            label5.Size = new Size(206, 25);
            label5.TabIndex = 11;
            label5.Text = "Don't have an Account?";
            // 
            // guna2ButtonSignUp
            // 
            guna2ButtonSignUp.BorderRadius = 20;
            guna2ButtonSignUp.BorderThickness = 2;
            guna2ButtonSignUp.CustomizableEdges = customizableEdges7;
            guna2ButtonSignUp.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonSignUp.FillColor = Color.Yellow;
            guna2ButtonSignUp.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ButtonSignUp.ForeColor = Color.Black;
            guna2ButtonSignUp.Location = new Point(332, 413);
            guna2ButtonSignUp.Name = "guna2ButtonSignUp";
            guna2ButtonSignUp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ButtonSignUp.Size = new Size(225, 56);
            guna2ButtonSignUp.TabIndex = 12;
            guna2ButtonSignUp.Text = "Sign Up";
            guna2ButtonSignUp.Click += guna2ButtonSignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 493);
            Controls.Add(guna2ButtonSignUp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(guna2ButtonLogin);
            Controls.Add(label2);
            Controls.Add(guna2TextBoxPinCode);
            Controls.Add(guna2TextBoxUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelExit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPinCode;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSignUp;
    }
}