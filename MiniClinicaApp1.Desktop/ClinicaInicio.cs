using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniClinicaApp1.Desktop.Models;

namespace MiniClinicaApp1.Desktop
{
    public partial class ClinicaInicio : Form
    {
        private List<Paciente> listaPacientes = new List<Paciente>();
        private int proximoId = 0;
        private int ultimoIdRegistrado = 0;
        private int proximoId1 = 0;
        private int ultimoIdRegistrado1 = 0;
        public ClinicaInicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreapellido = txtNombreApellido.Text;          
            int IdPaciente = proximoId;
            string edad = txtEdad.Text;
            int edad1 = int.Parse(edad);
            string dniPaciente = txtDni.Text;
            int dni = int.Parse(dniPaciente);

            GrillaPacientes.Rows.Add(
                IdPaciente, 
                txtNombreApellido.Text,
                txtEdad.Text, 
                txtDni.Text);

            proximoId++;
            ultimoIdRegistrado = IdPaciente;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            decimal precioConsulta;

            if (decimal.TryParse(txtTotal.Text.Replace("$", "").Trim(), out precioConsulta))
            {
                // Mostrar el valor como moneda (con $)
                txtTotal.Text = precioConsulta.ToString("C");

                // Podés usar precioConsulta con seguridad
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
            }


            int idCita = proximoId1;
            string motivoconsulta = txtMotivoConsulta.Text;
           
            Text = comboBox1Medico.Text;
            

            GrillaCitas.Rows.Add(
                idCita, 
                txtMotivoConsulta.Text, 
                comboBox1Medico.Text, 
                dateTimePicker1.Value.ToString("dd/MM/yyyy"),
                dateTimePicker2.Value.ToString("HH:mm tt"),
            precioConsulta.ToString("C"));

            proximoId1++;
            ultimoIdRegistrado1 = idCita;

        }

        

        private void ClinicaInicio_Load(object sender, EventArgs e)
        {

        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reciboDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboCita recibocita = new ReciboCita();
            recibocita.label1.Text = this.txtNombreApellido.Text;
            recibocita.label3.Text = this.txtDni.Text;
            int idActual = ultimoIdRegistrado;
            recibocita.label4.Text = idActual.ToString("D6");
            recibocita.label5.Text = comboBox1Medico.Text;
            recibocita.label6.Text = txtTotal.Text;
            recibocita.label7.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            recibocita.label8.Text = dateTimePicker2.Value.ToString("HH:mm tt");

            string fechaEmision = DateTime.Now.ToString("dd/MM/yyyy 'a las' hh:mm tt");
    
            string recibo = $"Emitido el: {fechaEmision}\n" +
                "Atentamente,\n" +
                "CLÍNICA MÉDICA SANAR BIEN\n";
            recibocita.label9.Text = recibo;
            this.Hide();
            recibocita.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMotivoConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
