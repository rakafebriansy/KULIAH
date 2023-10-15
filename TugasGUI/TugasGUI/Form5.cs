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
    public partial class Form5 : Form
    {
        List<object> list_perusahaan = new List<object>();
        public Form5()
        {
            InitializeComponent();
            GUI_1.Pariwisata pariwisata1 = new GUI_1.Pariwisata("PT. Traveloka", "Jl. Jendral Soedirman no.09, Jakarta Pusat", "Indonesia");
            GUI_1.Kesehatan kesehatan1 = new GUI_1.Kesehatan("Yuljee", "6 Dongpyeong-ro 116beon-gil, Busan", "Korea Selatan");
            list_perusahaan.Add(pariwisata1);
            list_perusahaan.Add(kesehatan1);
            dataGridView1.DataSource = list_perusahaan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 entri_data = new(this);
            entri_data.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list_perusahaan;
            System.Threading.Thread.Sleep(500);
        }
        public void setDataPerusahaan(object perusahaan)
        {
            list_perusahaan.Add(perusahaan);
        }
    }
}
namespace GUI_2
{
    public class Perusahaan
    {
        public string Kategori { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Negara { get; set; }
        public Perusahaan(string nama, string kategori, string alamat, string negara)
        {
            this.Kategori = kategori;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Negara = negara;
        }
    }
    class Agrikultur : Perusahaan
    {

        public Agrikultur(string nama, string alamat, string negara) : base(nama, "Agrikultur", alamat, negara) { }
    }
    class Kesehatan : Perusahaan
    {
        public Kesehatan(string nama, string alamat, string negara) : base(nama, "Kesehatan", alamat, negara) { }
    }
    class Ekonomi : Perusahaan
    {
        public Ekonomi(string nama, string alamat, string negara) : base(nama, "Ekonomi", alamat, negara) { }
    }
    class Pariwisata : Perusahaan
    {
        public Pariwisata(string nama, string alamat, string negara) : base(nama, "Pariwisata", alamat, negara) { }
    }
}
