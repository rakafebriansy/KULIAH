using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_GUI
{

    public partial class Form2 : Form
    {
        public Form2(string username)
        {
            InitializeComponent();
            label2.Text = $"sepuh {username}🙏";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
