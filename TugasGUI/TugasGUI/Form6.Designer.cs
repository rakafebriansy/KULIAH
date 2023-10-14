namespace TugasGUI
{
    partial class Form6
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(476, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(704, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(476, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(704, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(476, 434);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(704, 39);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(265, 42);
            label1.Name = "label1";
            label1.Size = new Size(864, 91);
            label1.TabIndex = 4;
            label1.Text = "ENTRI DATA PERUSAHAAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(169, 203);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(156, 280);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 6;
            label3.Text = "Alamat";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Agrikultur", "Kesehatan", "Ekonomi", "Pariwisata" });
            comboBox1.Location = new Point(837, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(344, 40);
            comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(141, 354);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 8;
            label4.Text = "Kategori";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(153, 434);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 9;
            label5.Text = "Negara";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Sans Serif Collection", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1027, 584);
            button1.Name = "button1";
            button1.Size = new Size(156, 56);
            button1.TabIndex = 10;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5582176;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 729);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}