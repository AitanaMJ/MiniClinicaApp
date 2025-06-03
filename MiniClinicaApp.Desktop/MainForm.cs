using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniClinicaApp.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreapellido = txtApellidoNombre.Text;
            string identificador = txtId.Text;
            int id = int.Parse(identificador);
            string edad = txtEdad.Text;
            int edad1 = int.Parse(edad);
            string dniPaciente = txtDni.Text;
            int dni = int.Parse(dniPaciente);

            grillaPacientes.Rows.Add(txtId.Text, txtApellidoNombre.Text, txtEdad.Text, txtDni.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void grillaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string idpaciente = txtIdPaciente.Text;
            string motivoconsulta = txtMotivoConsulta.Text;
            Text = comboBox1Medico.Text;
            label8.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            grillaCitas.Rows.Add(txtIdPaciente.Text, txtMotivoConsulta.Text, comboBox1Medico.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtApellidoNombre.Text = "";
            txtId.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdPaciente.Text = "";
            txtMotivoConsulta.Text = "";
            comboBox1Medico.Text = "";


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
