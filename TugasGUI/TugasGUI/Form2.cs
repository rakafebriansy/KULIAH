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
        private Form1 GUI1;
        public Form2(Form1 GUI1)
        {
            this.GUI1 = GUI1;
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
                    GUI_1.Agrikultur agrikultur = new GUI_1.Agrikultur(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI1.setDataPerusahaan(agrikultur);
                    break;
                case "Kesehatan":
                    GUI_1.Kesehatan kesehatan = new GUI_1.Kesehatan(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI1.setDataPerusahaan(kesehatan);
                    break;
                case "Ekonomi":
                    GUI_1.Ekonomi ekonomi = new GUI_1.Ekonomi(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI1.setDataPerusahaan(ekonomi);
                    break;
                case "Pariwisata":
                    GUI_1.Pariwisata pariwisata = new GUI_1.Pariwisata(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI1.setDataPerusahaan(pariwisata);
                    break;
                default:
                    MessageBox.Show("Kategori tidak valid!");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
