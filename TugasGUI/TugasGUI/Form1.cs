using System;
using System.Data;
using System.Windows.Forms.VisualStyles;

namespace TugasGUI
{
    public partial class Form1 : Form
    {
        List<Perusahaan>? list_perusahaan = new();
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
        public void setDataGUI1(Perusahaan perusahaan)
        {
            dataGridView1.Rows.Add(new object[] { perusahaan.Kategori, perusahaan.Nama, perusahaan.Alamat, perusahaan.Negara, "ubah", "hapus" });
        }
        public void setDataGUI2(Perusahaan perusahaan)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                List<Perusahaan>? pra_perusahaan = new List<Perusahaan>();
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    
                    string kategori = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                    switch (kategori)
                    {
                        case "Agrikultur":
                            Agrikultur agrikultur = new Agrikultur(dataGridView1.Rows[rows].Cells[1].Value.ToString(), dataGridView1.Rows[rows].Cells[2].Value.ToString(), dataGridView1.Rows[rows].Cells[3].Value.ToString());
                            pra_perusahaan.Add(agrikultur);
                            break;
                        case "Kesehatan":
                            Kesehatan kesehatan = new Kesehatan(dataGridView1.Rows[rows].Cells[1].Value.ToString(), dataGridView1.Rows[rows].Cells[2].Value.ToString(), dataGridView1.Rows[rows].Cells[3].Value.ToString());
                            pra_perusahaan.Add(kesehatan);
                            break;
                        case "Ekonomi":
                            Ekonomi ekonomi = new Ekonomi(dataGridView1.Rows[rows].Cells[1].Value.ToString(), dataGridView1.Rows[rows].Cells[2].Value.ToString(), dataGridView1.Rows[rows].Cells[3].Value.ToString());
                            pra_perusahaan.Add(ekonomi);
                            break;
                        case "Pariwisata":
                            Pariwisata pariwisata = new Pariwisata(dataGridView1.Rows[rows].Cells[1].Value.ToString(), dataGridView1.Rows[rows].Cells[2].Value.ToString(), dataGridView1.Rows[rows].Cells[3].Value.ToString());
                            pra_perusahaan.Add(pariwisata);
                            break;
                    }
                  
                }
                this.list_perusahaan = pra_perusahaan;
            }
            list_perusahaan.Add(perusahaan);
            dataGridView1.DataSource = list_perusahaan;

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