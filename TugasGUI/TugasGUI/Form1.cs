using System.Windows.Forms.VisualStyles;

namespace TugasGUI
{
    public partial class Form1 : Form
    {
        public int counter = 0;
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
            System.Threading.Thread.Sleep(500);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 4) //ubah
            {
                string?[] data = { dataGridView1.Rows[index].Cells[1].Value.ToString(), dataGridView1.Rows[index].Cells[2].Value.ToString(), dataGridView1.Rows[index].Cells[0].Value.ToString(), dataGridView1.Rows[index].Cells[3].Value.ToString() };
                Form3 ubah_data = new(this, data, index);
                ubah_data.ShowDialog();
            }
            if (e.ColumnIndex == 5) //hapus
            {

                dataGridView1.Rows.RemoveAt(index);
            }
        }
        public void setDataPerusahaan(GUI_1.Perusahaan perusahaan)
        {
            dataGridView1.Rows.Add(new object[] { perusahaan.Kategori, perusahaan.Nama, perusahaan.Alamat, perusahaan.Negara, "ubah", "hapus" });
        }
        public void editDataPerusahaan(int index, string?[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows[index].Cells[i].Value = data[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace GUI_1
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