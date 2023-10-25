namespace MiniMarketManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label_exit = new Label();
            TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            Button_login = new Guna.UI2.WinForms.Guna2Button();
            comboBox_role = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(411, 218);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(411, 282);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(522, 56);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 46);
            label3.TabIndex = 1;
            label3.Text = "LOGIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 24);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Sitka Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(100, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 39);
            label5.TabIndex = 7;
            label5.Text = "WELCOME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Sitka Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(84, 338);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(177, 39);
            label6.TabIndex = 8;
            label6.Text = "APPLICATION";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Sitka Display", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(65, 243);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(211, 53);
            label7.TabIndex = 8;
            label7.Text = "MiniMarket";
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_exit.ForeColor = Color.Goldenrod;
            label_exit.Location = new Point(830, -1);
            label_exit.Margin = new Padding(4, 0, 4, 0);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(38, 41);
            label_exit.TabIndex = 6;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            // 
            // TextBox_username
            // 
            TextBox_username.BorderRadius = 18;
            TextBox_username.Cursor = Cursors.IBeam;
            TextBox_username.CustomizableEdges = customizableEdges1;
            TextBox_username.DefaultText = "";
            TextBox_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Location = new Point(584, 209);
            TextBox_username.Margin = new Padding(4, 6, 4, 6);
            TextBox_username.Name = "TextBox_username";
            TextBox_username.PasswordChar = '\0';
            TextBox_username.PlaceholderText = "";
            TextBox_username.SelectedText = "";
            TextBox_username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_username.Size = new Size(267, 55);
            TextBox_username.TabIndex = 2;
            // 
            // TextBox_password
            // 
            TextBox_password.BorderRadius = 18;
            TextBox_password.Cursor = Cursors.IBeam;
            TextBox_password.CustomizableEdges = customizableEdges3;
            TextBox_password.DefaultText = "";
            TextBox_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Location = new Point(584, 272);
            TextBox_password.Margin = new Padding(4, 6, 4, 6);
            TextBox_password.Name = "TextBox_password";
            TextBox_password.PasswordChar = '●';
            TextBox_password.PlaceholderText = "";
            TextBox_password.SelectedText = "";
            TextBox_password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_password.Size = new Size(267, 55);
            TextBox_password.TabIndex = 3;
            TextBox_password.UseSystemPasswordChar = true;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.FillColor = Color.Gold;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-287, -31);
            guna2CircleButton1.Margin = new Padding(4, 5, 4, 5);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(659, 669);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = " ";
            // 
            // Button_login
            // 
            Button_login.BorderRadius = 18;
            Button_login.CustomizableEdges = customizableEdges6;
            Button_login.FillColor = Color.Goldenrod;
            Button_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_login.ForeColor = Color.Black;
            Button_login.Location = new Point(482, 382);
            Button_login.Margin = new Padding(4, 5, 4, 5);
            Button_login.Name = "Button_login";
            Button_login.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Button_login.Size = new Size(240, 44);
            Button_login.TabIndex = 4;
            Button_login.Text = "LOGIN";
            // 
            // comboBox_role
            // 
            comboBox_role.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_role.ForeColor = Color.Goldenrod;
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            comboBox_role.Location = new Point(584, 146);
            comboBox_role.Margin = new Padding(4, 5, 4, 5);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(265, 40);
            comboBox_role.TabIndex = 9;
            comboBox_role.Text = "Select Role";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 615);
            Controls.Add(comboBox_role);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_exit);
            Controls.Add(Button_login);
            Controls.Add(TextBox_password);
            Controls.Add(TextBox_username);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label_exit;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private ComboBox comboBox_role;
    }
}