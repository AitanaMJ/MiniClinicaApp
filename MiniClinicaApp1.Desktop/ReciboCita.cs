using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MiniClinicaApp1.Desktop
{
    public partial class ReciboCita : Form
    {
        public ReciboCita()
        {
            InitializeComponent();
        }

        private void ReciboCita_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClinicaInicio inicio = new ClinicaInicio();
            this.Hide();
            inicio.Show();
        }
    }
}
