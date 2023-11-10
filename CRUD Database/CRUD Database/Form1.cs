using CRUD_Database;
using Npgsql;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD_Database
{
    public partial class Form1 : Form
    {
        Model model;
        Form2 form2;
        public Form1(Model model)
        {
            Form2 form2 = new Form2();
            this.model = model;
            this.form2 = form2;
            InitializeComponent();
            NpgsqlDataReader reader = this.model.readDataMitra();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1], reader[2].ToString());
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_mitra = textBox1.Text;
            string deskripsi_mitra = richTextBox1.Text;
            model.createDataMitra(nama_mitra, deskripsi_mitra);
            dataGridView1.Rows.Add(nama_mitra, deskripsi_mitra);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string nama_mitra = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (e.ColumnIndex == 2)
            {
                form2.setTextbox(dataGridView1.Rows[index].Cells[0].Value.ToString(), dataGridView1.Rows[index].Cells[1].Value.ToString());
                form2.ShowDialog();
                string[] data = form2.getData();
                model.updateDataMitra(data);
                dataGridView1.Rows[index].Cells[0].Value = data[1];
                dataGridView1.Rows[index].Cells[1].Value = data[2];
            }
            else if (e.ColumnIndex == 3)
            {
                model.deleteDataMitra(nama_mitra);
                dataGridView1.Rows.RemoveAt(index);
            }
        }
    }
}
