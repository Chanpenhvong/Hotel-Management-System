namespace HotelManagementSystemII
{
    partial class EmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            TextIdentityid = new TextBox();
            TextName = new TextBox();
            label3 = new Label();
            TextCardno = new TextBox();
            label4 = new Label();
            TextPosition = new TextBox();
            label5 = new Label();
            TextUsername = new TextBox();
            label6 = new Label();
            label7 = new Label();
            TextPassword = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "IdentityID";
            // 
            // TextIdentityid
            // 
            TextIdentityid.Location = new Point(12, 119);
            TextIdentityid.Multiline = true;
            TextIdentityid.Name = "TextIdentityid";
            TextIdentityid.Size = new Size(202, 35);
            TextIdentityid.TabIndex = 2;
            // 
            // TextName
            // 
            TextName.Location = new Point(12, 188);
            TextName.Multiline = true;
            TextName.Name = "TextName";
            TextName.Size = new Size(202, 35);
            TextName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // TextCardno
            // 
            TextCardno.Location = new Point(12, 259);
            TextCardno.Multiline = true;
            TextCardno.Name = "TextCardno";
            TextCardno.Size = new Size(202, 35);
            TextCardno.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 5;
            label4.Text = "CardNo";
            // 
            // TextPosition
            // 
            TextPosition.Location = new Point(12, 329);
            TextPosition.Multiline = true;
            TextPosition.Name = "TextPosition";
            TextPosition.Size = new Size(202, 35);
            TextPosition.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 7;
            label5.Text = "Position";
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(12, 461);
            TextUsername.Multiline = true;
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(202, 35);
            TextUsername.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 428);
            label6.Name = "label6";
            label6.Size = new Size(114, 30);
            label6.TabIndex = 9;
            label6.Text = "UserName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(-2, 367);
            label7.Name = "label7";
            label7.Size = new Size(228, 50);
            label7.TabIndex = 11;
            label7.Text = "UserAccount";
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(12, 532);
            TextPassword.Multiline = true;
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(202, 35);
            TextPassword.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(12, 499);
            label8.Name = "label8";
            label8.Size = new Size(104, 30);
            label8.TabIndex = 12;
            label8.Text = "Password";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(246, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(638, 405);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(298, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 47);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdate.Location = new Point(450, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 47);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 583);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(TextPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TextUsername);
            Controls.Add(label6);
            Controls.Add(TextPosition);
            Controls.Add(label5);
            Controls.Add(TextCardno);
            Controls.Add(label4);
            Controls.Add(TextName);
            Controls.Add(label3);
            Controls.Add(TextIdentityid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextIdentityid;
        private TextBox TextName;
        private Label label3;
        private TextBox TextCardno;
        private Label label4;
        private TextBox TextPosition;
        private Label label5;
        private TextBox TextUsername;
        private Label label6;
        private Label label7;
        private TextBox TextPassword;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnUpdate;
    }
}