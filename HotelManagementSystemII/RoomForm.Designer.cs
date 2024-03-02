namespace HotelManagementSystemII
{
    partial class RoomForm
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
            TextPrice = new TextBox();
            TextRoomid = new TextBox();
            TextRNumber = new TextBox();
            cbBed = new ComboBox();
            cbRtype = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "RoomID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 0;
            label2.Text = "RNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 263);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 0;
            label3.Text = "RoomType";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(46, 30);
            label4.TabIndex = 0;
            label4.Text = "Bed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 322);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 0;
            label5.Text = "Price";
            // 
            // TextPrice
            // 
            TextPrice.Location = new Point(12, 355);
            TextPrice.Multiline = true;
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(220, 39);
            TextPrice.TabIndex = 4;
            // 
            // TextRoomid
            // 
            TextRoomid.Location = new Point(12, 88);
            TextRoomid.Multiline = true;
            TextRoomid.Name = "TextRoomid";
            TextRoomid.ReadOnly = true;
            TextRoomid.Size = new Size(220, 39);
            TextRoomid.TabIndex = 1;
            // 
            // TextRNumber
            // 
            TextRNumber.Location = new Point(12, 162);
            TextRNumber.Multiline = true;
            TextRNumber.Name = "TextRNumber";
            TextRNumber.Size = new Size(220, 39);
            TextRNumber.TabIndex = 1;
            // 
            // cbBed
            // 
            cbBed.FormattingEnabled = true;
            cbBed.Items.AddRange(new object[] { "Single", "Double" });
            cbBed.Location = new Point(12, 237);
            cbBed.Name = "cbBed";
            cbBed.Size = new Size(220, 23);
            cbBed.TabIndex = 2;
            // 
            // cbRtype
            // 
            cbRtype.FormattingEnabled = true;
            cbRtype.Items.AddRange(new object[] { "AC", "Non-AC" });
            cbRtype.Location = new Point(12, 296);
            cbRtype.Name = "cbRtype";
            cbRtype.Size = new Size(220, 23);
            cbRtype.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(647, 397);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 33);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(134, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 33);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 515);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(cbRtype);
            Controls.Add(cbBed);
            Controls.Add(TextRoomid);
            Controls.Add(TextRNumber);
            Controls.Add(TextPrice);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextPrice;
        private TextBox TextRoomid;
        private TextBox TextRNumber;
        private ComboBox cbBed;
        private ComboBox cbRtype;
        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnUpdate;
    }
}