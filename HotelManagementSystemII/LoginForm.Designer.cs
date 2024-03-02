namespace HotelManagementSystemII
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextUsername = new TextBox();
            TextPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(145, 12);
            label1.Name = "label1";
            label1.Size = new Size(111, 50);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(77, 135);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(77, 206);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // TextUsername
            // 
            TextUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TextUsername.Location = new Point(73, 168);
            TextUsername.Multiline = true;
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(232, 35);
            TextUsername.TabIndex = 1;
            // 
            // TextPassword
            // 
            TextPassword.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            TextPassword.Location = new Point(77, 239);
            TextPassword.Multiline = true;
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(232, 35);
            TextPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(73, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location = new Point(194, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 44);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TextPassword);
            panel1.Controls.Add(TextUsername);
            panel1.Location = new Point(348, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 479);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1118, 590);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextUsername;
        private TextBox TextPassword;
        private Button btnLogin;
        private Button btnExit;
        private Panel panel1;
    }
}