namespace TugasGUI
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
            dataGridView1 = new DataGridView();
            Kategori = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            Negara = new DataGridViewTextBoxColumn();
            Ubah = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kategori, Nama, Alamat, Negara, Ubah, Hapus });
            dataGridView1.Location = new Point(14, 125);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1346, 590);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Kategori
            // 
            Kategori.HeaderText = "Kategori";
            Kategori.MinimumWidth = 10;
            Kategori.Name = "Kategori";
            Kategori.ReadOnly = true;
            Kategori.Width = 135;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 10;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            Nama.Width = 150;
            // 
            // Alamat
            // 
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 10;
            Alamat.Name = "Alamat";
            Alamat.ReadOnly = true;
            Alamat.Width = 150;
            // 
            // Negara
            // 
            Negara.HeaderText = "Negara";
            Negara.MinimumWidth = 10;
            Negara.Name = "Negara";
            Negara.ReadOnly = true;
            Negara.Width = 125;
            // 
            // Ubah
            // 
            Ubah.HeaderText = "Ubah";
            Ubah.MinimumWidth = 10;
            Ubah.Name = "Ubah";
            Ubah.ReadOnly = true;
            Ubah.Resizable = DataGridViewTriState.False;
            Ubah.Width = 200;
            // 
            // Hapus
            // 
            Hapus.HeaderText = "Hapus";
            Hapus.MinimumWidth = 10;
            Hapus.Name = "Hapus";
            Hapus.ReadOnly = true;
            Hapus.Resizable = DataGridViewTriState.False;
            Hapus.Width = 200;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Sans Serif Collection", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1194, 61);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(166, 54);
            button1.TabIndex = 1;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._5582176;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 729);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perusahaan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn Negara;
        private DataGridViewTextBoxColumn Ubah;
        private DataGridViewTextBoxColumn Hapus;
    }
}