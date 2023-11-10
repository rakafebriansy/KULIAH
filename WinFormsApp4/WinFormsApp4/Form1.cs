using Npgsql;
using System;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        public Form1(NpgsqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO mahasiswa (nama_mahasiswa) VALUES ('Arie');", conn); //query
            //cmd.ExecuteNonQuery(); //execute query

            cmd = new NpgsqlCommand("SELECT * FROM mahasiswa;",conn); //query
            NpgsqlDataReader reader = cmd.ExecuteReader(); //execute query
            while(reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1]);
            }
            reader.Close();
        }
    }
    class Model
    {
        public int id_mahasiswa;
        public string nama_mahasiswa;
        public Model(int id_mahasiswa, string nama_mahasiswa)
        {
            this.id_mahasiswa = id_mahasiswa;
            this.nama_mahasiswa = nama_mahasiswa;
        }
    }
}