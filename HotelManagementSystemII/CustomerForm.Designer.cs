namespace HotelManagementSystemII
{
    partial class CustomerForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TextCustomerId = new TextBox();
            TextName = new TextBox();
            TextPhone = new TextBox();
            TextNationality = new TextBox();
            TextNICNO = new TextBox();
            label9 = new Label();
            CbGender = new ComboBox();
            dateTimeChechin = new DateTimePicker();
            dateTimeDateofbirth = new DateTimePicker();
            btnCheckin = new Button();
            TextRnumber = new TextBox();
            nane = new Label();
            TextRtype = new TextBox();
            labe1 = new Label();
            TextBed = new TextBox();
            lable3 = new Label();
            TextPrice = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 50);
            label1.TabIndex = 0;
            label1.Text = "Customer Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(15, 240);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 1;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 320);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 1;
            label5.Text = "Nationality:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(355, 80);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 1;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(12, 397);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 1;
            label7.Text = "NICNO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(355, 240);
            label8.Name = "label8";
            label8.Size = new Size(134, 32);
            label8.TabIndex = 1;
            label8.Text = "DateOfBirth";
            label8.Click += label8_Click;
            // 
            // TextCustomerId
            // 
            TextCustomerId.Location = new Point(12, 115);
            TextCustomerId.Multiline = true;
            TextCustomerId.Name = "TextCustomerId";
            TextCustomerId.Size = new Size(233, 42);
            TextCustomerId.TabIndex = 2;
            // 
            // TextName
            // 
            TextName.Location = new Point(12, 195);
            TextName.Multiline = true;
            TextName.Name = "TextName";
            TextName.Size = new Size(233, 42);
            TextName.TabIndex = 2;
            // 
            // TextPhone
            // 
            TextPhone.Location = new Point(15, 275);
            TextPhone.Multiline = true;
            TextPhone.Name = "TextPhone";
            TextPhone.Size = new Size(233, 42);
            TextPhone.TabIndex = 2;
            // 
            // TextNationality
            // 
            TextNationality.Location = new Point(12, 352);
            TextNationality.Multiline = true;
            TextNationality.Name = "TextNationality";
            TextNationality.Size = new Size(233, 42);
            TextNationality.TabIndex = 2;
            // 
            // TextNICNO
            // 
            TextNICNO.Location = new Point(12, 431);
            TextNICNO.Multiline = true;
            TextNICNO.Name = "TextNICNO";
            TextNICNO.Size = new Size(233, 42);
            TextNICNO.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(355, 160);
            label9.Name = "label9";
            label9.Size = new Size(107, 32);
            label9.TabIndex = 1;
            label9.Text = "Check-IN";
            // 
            // CbGender
            // 
            CbGender.FormattingEnabled = true;
            CbGender.Location = new Point(355, 134);
            CbGender.Name = "CbGender";
            CbGender.Size = new Size(233, 23);
            CbGender.TabIndex = 3;
            // 
            // dateTimeChechin
            // 
            dateTimeChechin.Location = new Point(355, 195);
            dateTimeChechin.Name = "dateTimeChechin";
            dateTimeChechin.Size = new Size(233, 23);
            dateTimeChechin.TabIndex = 4;
            // 
            // dateTimeDateofbirth
            // 
            dateTimeDateofbirth.Location = new Point(355, 275);
            dateTimeDateofbirth.Name = "dateTimeDateofbirth";
            dateTimeDateofbirth.Size = new Size(233, 23);
            dateTimeDateofbirth.TabIndex = 4;
            // 
            // btnCheckin
            // 
            btnCheckin.Location = new Point(462, 343);
            btnCheckin.Name = "btnCheckin";
            btnCheckin.Size = new Size(126, 39);
            btnCheckin.TabIndex = 5;
            btnCheckin.Text = "Check In";
            btnCheckin.UseVisualStyleBackColor = true;
            btnCheckin.Click += btnCheckin_Click;
            // 
            // TextRnumber
            // 
            TextRnumber.Location = new Point(660, 115);
            TextRnumber.Multiline = true;
            TextRnumber.Name = "TextRnumber";
            TextRnumber.Size = new Size(233, 42);
            TextRnumber.TabIndex = 7;
            // 
            // nane
            // 
            nane.AutoSize = true;
            nane.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            nane.Location = new Point(660, 80);
            nane.Name = "nane";
            nane.Size = new Size(110, 32);
            nane.TabIndex = 6;
            nane.Text = "RNumber";
            // 
            // TextRtype
            // 
            TextRtype.Location = new Point(660, 195);
            TextRtype.Multiline = true;
            TextRtype.Name = "TextRtype";
            TextRtype.Size = new Size(233, 42);
            TextRtype.TabIndex = 9;
            // 
            // labe1
            // 
            labe1.AutoSize = true;
            labe1.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labe1.Location = new Point(660, 160);
            labe1.Name = "labe1";
            labe1.Size = new Size(75, 32);
            labe1.TabIndex = 8;
            labe1.Text = "RType";
            // 
            // TextBed
            // 
            TextBed.Location = new Point(660, 278);
            TextBed.Multiline = true;
            TextBed.Name = "TextBed";
            TextBed.Size = new Size(233, 42);
            TextBed.TabIndex = 11;
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lable3.Location = new Point(660, 243);
            lable3.Name = "lable3";
            lable3.Size = new Size(51, 32);
            lable3.TabIndex = 10;
            lable3.Text = "Bed";
            // 
            // TextPrice
            // 
            TextPrice.Location = new Point(660, 361);
            TextPrice.Multiline = true;
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(233, 42);
            TextPrice.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(660, 326);
            label10.Name = "label10";
            label10.Size = new Size(62, 32);
            label10.TabIndex = 12;
            label10.Text = "Price";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 538);
            Controls.Add(TextPrice);
            Controls.Add(label10);
            Controls.Add(TextBed);
            Controls.Add(lable3);
            Controls.Add(TextRtype);
            Controls.Add(labe1);
            Controls.Add(TextRnumber);
            Controls.Add(nane);
            Controls.Add(btnCheckin);
            Controls.Add(dateTimeDateofbirth);
            Controls.Add(dateTimeChechin);
            Controls.Add(CbGender);
            Controls.Add(TextNICNO);
            Controls.Add(TextNationality);
            Controls.Add(TextPhone);
            Controls.Add(TextName);
            Controls.Add(TextCustomerId);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
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
        private Label label8;
        private TextBox TextCustomerId;
        private TextBox TextName;
        private TextBox TextPhone;
        private TextBox TextNationality;
        private TextBox TextNICNO;
        private Label label9;
        private ComboBox CbGender;
        private DateTimePicker dateTimeChechin;
        private DateTimePicker dateTimeDateofbirth;
        private Button btnCheckin;
        private TextBox TextRnumber;
        private Label nane;
        private TextBox TextRtype;
        private Label labe1;
        private TextBox TextBed;
        private Label lable3;
        private TextBox TextPrice;
        private Label label10;
    }
}