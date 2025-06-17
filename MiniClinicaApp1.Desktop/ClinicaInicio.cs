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

        private List<Cita>listaCitas = new List<Cita>();       
        private int proximoId1 = 0;
        private int ultimoIdRegistrado1 = 0;
        public ClinicaInicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreyapellido = txtNombreApellido.Text;          
            int idpaciente = proximoId;
            int edad = int.Parse(txtEdad.Text);
            int dni = int.Parse(txtDni.Text);
            

            GrillaPacientes.Rows.Add(
                idpaciente, 
                nombreyapellido,
                edad, 
                dni);

            proximoId++;
            ultimoIdRegistrado = idpaciente;

            Paciente paciente = new Paciente(idpaciente,nombreyapellido,edad,dni);

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            decimal total;

            if (decimal.TryParse(txtTotal.Text.Replace("$", "").Trim(), out total))
            {
                
                txtTotal.Text = total.ToString("C");

               
            }
            

            int idCita = proximoId1;
            string motivo = txtMotivoConsulta.Text;
            DateTime fecha = dateTimePicker1.Value;
            DateTime hora = dateTimePicker2.Value;


            string medico = comboBox1Medico.Text;
            

            GrillaCitas.Rows.Add(
               idCita, 
               motivo,
               medico, 
               fecha.ToString("dd/MM/yyyy "),
               hora.ToString("HH:mm tt"),

            total.ToString("C"));

            proximoId1++;
            ultimoIdRegistrado1 = idCita;

            Cita nuevaCita = new Cita(idCita, motivo, fecha, hora, total, medico);

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void GrillaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
