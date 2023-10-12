using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private BindingList<Pariwisata> pariwisataList;

        public MainForm()
        {
            InitializeComponent();

            // Inisialisasi DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nama", "Nama");
            dataGridView1.Columns.Add("Lokasi", "Lokasi");
            dataGridView1.Columns.Add("Deskripsi", "Deskripsi");

            // Inisialisasi daftar Pariwisata
            pariwisataList = new BindingList<Pariwisata>
        {
            new Pariwisata { Nama = "Tempat A", Lokasi = "Lokasi A", Deskripsi = "Deskripsi A" },
            new Pariwisata { Nama = "Tempat B", Lokasi = "Lokasi B", Deskripsi = "Deskripsi B" },
        };

            // Bind DataGridView dengan daftar Pariwisata
            dataGridView1.DataSource = pariwisataList;
        }

        // Event handler untuk tombol "Tambah Data"
        private void btnTambahData_Click(object sender, EventArgs e)
        {
            // Membuka form tambahan untuk menambahkan data baru
            using (TambahDataForm tambahDataForm = new TambahDataForm())
            {
                if (tambahDataForm.ShowDialog() == DialogResult.OK)
                {
                    // Menambahkan data baru ke dalam DataGridView
                    pariwisataList.Add(tambahDataForm.PariwisataBaru);
                }
            }
        }
    }
}