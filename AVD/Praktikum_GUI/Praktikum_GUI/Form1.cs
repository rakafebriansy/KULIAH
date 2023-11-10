using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Praktikum_GUI
{
    public partial class Form1 : Form
    {
        private string username1 = "Bima";
        private string username2 = "Ando";
        private string password = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == username1 || textBox1.Text == username2) && textBox2.Text == password)
            {
                Form2 form_utama = new Form2(textBox1.Text);
                form_utama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }
    }
}