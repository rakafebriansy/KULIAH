using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGUI
{
    public partial class Form2 : Form
    {
        private Form1 data_tampil;
        public Form2(Form1 data_tampil)
        {
            this.data_tampil = data_tampil;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Agrikultur":
                    Agrikultur agrikultur = new Agrikultur(textBox1.Text, textBox2.Text, textBox3.Text);
                    data_tampil.setDataPerusahaan(agrikultur);
                    break;
                case "Kesehatan":
                    Kesehatan kesehatan = new Kesehatan(textBox1.Text, textBox2.Text, textBox3.Text);
                    data_tampil.setDataPerusahaan(kesehatan);
                    break;
                case "Ekonomi":
                    Ekonomi ekonomi = new Ekonomi(textBox1.Text, textBox2.Text, textBox3.Text);
                    data_tampil.setDataPerusahaan(ekonomi);
                    break;
                case "Pariwisata":
                    Pariwisata pariwisata = new Pariwisata(textBox1.Text, textBox2.Text, textBox3.Text);
                    data_tampil.setDataPerusahaan(pariwisata);
                    break;
            }
            
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
