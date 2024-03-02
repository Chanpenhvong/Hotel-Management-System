namespace HotelManagementSystemII
{
    partial class CheckoutForm
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
            Textname = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateCheckout = new DateTimePicker();
            label5 = new Label();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 50);
            label1.TabIndex = 0;
            label1.Text = "Customer Check-Out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // Textname
            // 
            Textname.Location = new Point(95, 64);
            Textname.Multiline = true;
            Textname.Name = "Textname";
            Textname.Size = new Size(220, 36);
            Textname.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1150, 317);
            dataGridView1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 461);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 36);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 465);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(391, 465);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 36);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(319, 469);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 6;
            label4.Text = "Room:";
            // 
            // dateCheckout
            // 
            dateCheckout.Location = new Point(630, 492);
            dateCheckout.Name = "dateCheckout";
            dateCheckout.Size = new Size(200, 23);
            dateCheckout.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(630, 450);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 6;
            label5.Text = "Check-Out";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(975, 464);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(158, 45);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = "Check-Out";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 535);
            Controls.Add(btnCheckout);
            Controls.Add(dateCheckout);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(Textname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckoutForm";
            Text = "CheckoutForm";
            Load += CheckoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Textname;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateCheckout;
        private Label label5;
        private Button btnCheckout;
    }
}