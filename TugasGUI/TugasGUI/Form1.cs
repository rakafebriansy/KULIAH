using System.Windows.Forms.VisualStyles;

namespace TugasGUI
{
    public partial class Form1 : Form
    {
        public int counter = 0;
        public static List<Perusahaan> list_perusahaan = new List<Perusahaan>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Perusahaan_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 entri_data = new(this);
            entri_data.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setDataPerusahaan(Perusahaan perusahaan)
        {
            dataGridView1.Rows.Add(new object[] { perusahaan.Id, perusahaan.Kategori, perusahaan.Nama, perusahaan.Alamat, perusahaan.Negara });
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

    public class Perusahaan
    {
        public static int counter = 0;
        public int Id { get; set; }
        public string Kategori { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Negara { get; set; }
        public Perusahaan(string nama, string kategori, string alamat, string negara)
        {
            counter++;
            this.Id = counter;
            this.Kategori = kategori;
            this.Nama = nama;
            this.Alamat = alamat;
            this.Negara = negara;
        }
    }
    class Agrikultur : Perusahaan
    {

        public Agrikultur(string nama, string alamat, string negara) : base(nama, "Agrikultur", alamat, negara)
        {

        }
    }
    class Kesehatan : Perusahaan
    {
        public Kesehatan(string nama, string alamat, string negara) : base(nama, "Kesehatan", alamat, negara)
        {

        }
    }
    class Ekonomi : Perusahaan
    {
        public Ekonomi(string nama, string alamat, string negara) : base(nama, "Ekonomi", alamat, negara)
        {

        }
    }
    class Pariwisata : Perusahaan
    {
        public Pariwisata(string nama, string alamat, string negara) : base(nama, "Pariwisata", alamat, negara)
        {

        }
    }
}