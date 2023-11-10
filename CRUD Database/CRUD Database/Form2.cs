using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Database
{
    public partial class Form2 : Form
    {
        private string? nama_mitra_lama;
        private string? nama_mitra;
        private string? deskripsi_mitra;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_mitra = textBox1.Text;
            string deskripsi_mitra = richTextBox1.Text;
            this.nama_mitra = nama_mitra;
            this.deskripsi_mitra = deskripsi_mitra;
            this.Hide();
        }
        public string[] getData()
        {
            string[] data = { nama_mitra_lama, nama_mitra, deskripsi_mitra };
            return data;
        }
        public void setTextbox(string nama_mitra, string deskripsi_mitra)
        {
            nama_mitra_lama = nama_mitra;
            textBox1.Text = nama_mitra;
            richTextBox1.Text = deskripsi_mitra;
        }
    }
}
