namespace TugasGUI
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 35);
            label1.Name = "label1";
            label1.Size = new Size(818, 91);
            label1.TabIndex = 0;
            label1.Text = "EDIT DATA PERUSAHAAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(208, 218);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(195, 286);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 2;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(193, 416);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 3;
            label4.Text = "Negara";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(180, 354);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 4;
            label5.Text = "Kategori";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(549, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(709, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(549, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(709, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(557, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(700, 39);
            textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Agrikultur", "Kesehatan", "Ekonomi", "Pariwisata" });
            comboBox1.Location = new Point(942, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 40);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Sans Serif Collection", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1098, 581);
            button1.Name = "button1";
            button1.Size = new Size(159, 62);
            button1.TabIndex = 9;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._5582176;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 729);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
    }
}