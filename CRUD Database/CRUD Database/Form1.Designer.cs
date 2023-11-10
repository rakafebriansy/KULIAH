namespace CRUD_Database
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
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            nama_mitra = new DataGridViewTextBoxColumn();
            deskripsi_mitra = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            hapus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama_mitra, deskripsi_mitra, edit, hapus });
            dataGridView1.Location = new Point(587, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(975, 671);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 203);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "Nama Mitra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 264);
            label2.Name = "label2";
            label2.Size = new Size(173, 32);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi Mitra";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(228, 264);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(331, 145);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 39);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(228, 426);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(619, 9);
            label3.Name = "label3";
            label3.Size = new Size(376, 93);
            label3.TabIndex = 6;
            label3.Text = "FORM MITRA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 133);
            label4.Name = "label4";
            label4.Size = new Size(340, 50);
            label4.TabIndex = 7;
            label4.Text = "Tambah Mitra Baru";
            // 
            // nama_mitra
            // 
            nama_mitra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nama_mitra.FillWeight = 83.26057F;
            nama_mitra.HeaderText = "Nama Mitra";
            nama_mitra.MinimumWidth = 10;
            nama_mitra.Name = "nama_mitra";
            nama_mitra.ReadOnly = true;
            nama_mitra.Resizable = DataGridViewTriState.True;
            // 
            // deskripsi_mitra
            // 
            deskripsi_mitra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            deskripsi_mitra.FillWeight = 211.560654F;
            deskripsi_mitra.HeaderText = "Deskripsi Mitra";
            deskripsi_mitra.MinimumWidth = 10;
            deskripsi_mitra.Name = "deskripsi_mitra";
            deskripsi_mitra.ReadOnly = true;
            // 
            // edit
            // 
            edit.FillWeight = 51.2820473F;
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 10;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Resizable = DataGridViewTriState.True;
            edit.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // hapus
            // 
            hapus.FillWeight = 53.89671F;
            hapus.HeaderText = "Hapus";
            hapus.MinimumWidth = 10;
            hapus.Name = "hapus";
            hapus.Resizable = DataGridViewTriState.True;
            hapus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 829);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitra";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn nama_mitra;
        private DataGridViewTextBoxColumn deskripsi_mitra;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn hapus;
    }
}