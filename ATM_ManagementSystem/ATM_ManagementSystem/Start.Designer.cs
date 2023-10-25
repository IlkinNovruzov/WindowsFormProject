namespace ATM_ManagementSystem
{
    partial class Start
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            MyProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            labelPercent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(97, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 303);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, -4);
            label3.Name = "label3";
            label3.Size = new Size(490, 102);
            label3.TabIndex = 0;
            label3.Text = "              Welcome\r\nATM Management System";
            // 
            // MyProgressBar
            // 
            MyProgressBar.BackColor = Color.Turquoise;
            MyProgressBar.CustomizableEdges = customizableEdges1;
            MyProgressBar.FillColor = Color.White;
            MyProgressBar.Location = new Point(-3, 399);
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.ProgressColor = Color.Cyan;
            MyProgressBar.ProgressColor2 = Color.Cyan;
            MyProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MyProgressBar.Size = new Size(758, 38);
            MyProgressBar.TabIndex = 4;
            MyProgressBar.Text = "guna2ProgressBar1";
            MyProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labelPercent
            // 
            labelPercent.AutoSize = true;
            labelPercent.BackColor = Color.Transparent;
            labelPercent.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPercent.Location = new Point(678, 358);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(41, 38);
            labelPercent.TabIndex = 5;
            labelPercent.Text = "%";
            labelPercent.Click += labelPercent_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 437);
            Controls.Add(label3);
            Controls.Add(labelPercent);
            Controls.Add(MyProgressBar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ProgressBar MyProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Label labelPercent;
    }
}