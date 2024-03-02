namespace HotelManagementSystemII
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAddroom = new Button();
            btnCmRegister = new Button();
            btnCheckout = new Button();
            btnEmployee = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddroom
            // 
            btnAddroom.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddroom.Location = new Point(272, 245);
            btnAddroom.Name = "btnAddroom";
            btnAddroom.Size = new Size(235, 59);
            btnAddroom.TabIndex = 2;
            btnAddroom.Text = "Add Room";
            btnAddroom.UseVisualStyleBackColor = true;
            btnAddroom.Click += btnAddroom_Click;
            // 
            // btnCmRegister
            // 
            btnCmRegister.BackColor = Color.Transparent;
            btnCmRegister.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCmRegister.Location = new Point(565, 245);
            btnCmRegister.Name = "btnCmRegister";
            btnCmRegister.Size = new Size(235, 59);
            btnCmRegister.TabIndex = 2;
            btnCmRegister.Text = "Customer Register";
            btnCmRegister.UseVisualStyleBackColor = false;
            btnCmRegister.Click += btnCmRegister_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCheckout.Location = new Point(565, 341);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(235, 59);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Check-Out";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEmployee.Location = new Point(272, 341);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(235, 59);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semilight", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(254, 69);
            label2.Name = "label2";
            label2.Size = new Size(590, 130);
            label2.TabIndex = 3;
            label2.Text = "Hotel Management System \r\n             Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 126);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 5;
            label3.Text = "Norton University ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(180, 17);
            label4.TabIndex = 8;
            label4.Text = "Year II Samester II Group 5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 160);
            label1.Name = "label1";
            label1.Size = new Size(185, 17);
            label1.TabIndex = 9;
            label1.Text = "Lecturer Mr. Nguon Viravud";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(423, 424);
            button1.Name = "button1";
            button1.Size = new Size(235, 59);
            button1.TabIndex = 11;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1118, 590);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEmployee);
            Controls.Add(btnCheckout);
            Controls.Add(btnCmRegister);
            Controls.Add(btnAddroom);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddroom;
        private Button btnCmRegister;
        private Button btnCheckout;
        private Button btnEmployee;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}