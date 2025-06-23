using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Desktop
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CitasDesktop form = new CitasDesktop();
            this.Hide();
            form.Show();
        }

        private void Recibo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
