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
    public partial class Form6 : Form
    {
        public Form5 GUI2;
        public Form6(Form5 GUI2)
        {
            InitializeComponent();
            this.GUI2 = GUI2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Agrikultur":
                    GUI_2.Agrikultur agrikultur = new GUI_2.Agrikultur(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI2.setDataPerusahaan(agrikultur);
                    break;
                case "Kesehatan":
                    GUI_2.Kesehatan kesehatan = new GUI_2.Kesehatan(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI2.setDataPerusahaan(kesehatan);
                    break;
                case "Ekonomi":
                    GUI_2.Ekonomi ekonomi = new GUI_2.Ekonomi(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI2.setDataPerusahaan(ekonomi);
                    break;
                case "Pariwisata":
                    GUI_2.Pariwisata pariwisata = new GUI_2.Pariwisata(textBox1.Text, textBox2.Text, textBox3.Text);
                    GUI2.setDataPerusahaan(pariwisata);
                    break;
                default:
                    MessageBox.Show("Kategori tidak valid!");
                    break;
            }
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
