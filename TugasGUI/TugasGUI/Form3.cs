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

namespace TugasGUI
{
    public partial class Form3 : Form
    {
        private Form1 data_tampil;
        private int index;
        public Form3(Form1 data_tampil, string[] data, int index)
        {
            InitializeComponent();
            textBox1.Text = data[0];
            textBox2.Text = data[1];
            comboBox1.Text = data[2];
            textBox3.Text = data[3];
            this.index = index;
            this.data_tampil = data_tampil;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Agrikultur" || comboBox1.Text == "Kesehatan" || comboBox1.Text == "Pariwisata" || comboBox1.Text == "Ekonomi")
            {
                string[] data = { comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text };
                data_tampil.editDataPerusahaan(this.index, data);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kategori Tidak Valid");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
