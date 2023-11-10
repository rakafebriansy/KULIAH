using CRUD.app;
using System.Windows.Forms.VisualStyles;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private Service service;
        // private List<Ledger> ledgers;
        public Form1()
        {
            Repo repo = new Repo();
            service = new Service(repo);
            // ledgers = service.DepositList();
            InitializeComponent();

            // cara menambah baris di datagridview
            //for (int i = 1; i <= 100; i++)
            //{
            //    dataGridView1.Rows.Add(new object[] { i, 100 });
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ledger ledger = service.Deposit(balancefield.Value);
            dataGridView1.Rows.Add(new object[] { 1, ledger.deposit, "update", "delete" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? data = dataGridView1.Rows[0].Cells[0].Value.ToString();
            dataGridView1.Rows[0].Cells[1].Value = "rp. " + data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(e.ColumnIndex == 3)
            {
                dataGridView1.Rows.RemoveAt(index);
            }
            if(e.ColumnIndex == 2)
            {
                string? data = dataGridView1.Rows[index].Cells[1].Value.ToString();
                dataGridView1.Rows[index].Cells[1].Value = "rp. " + data;
            }
        }
    }
}