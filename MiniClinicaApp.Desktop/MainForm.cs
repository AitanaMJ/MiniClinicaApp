using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Desktop
{
    public partial class MainForm : Form
    {
        private List<Paciente> listaPacientes = new List<Paciente>();
        private int proximoId = 1;
        private int proximoId1 = 1;


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
            //string identificador = txtId.Text;
            //int id = int.Parse(identificador);
            int Id = proximoId;
            string edad = txtEdad.Text;
            int edad1 = int.Parse(edad);

            string dniPaciente = txtDni.Text;
            int dni = int.Parse(dniPaciente);

            grillaPacientes.Rows.Add(proximoId, txtApellidoNombre.Text, txtEdad.Text, txtDni.Text);
            proximoId++;


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
            int idpaciente = proximoId1;
            string motivoconsulta = txtMotivoConsulta.Text;
            Text = comboBox1Medico.Text;
            label8.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            grillaCitas.Rows.Add(proximoId1, txtMotivoConsulta.Text, comboBox1Medico.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            proximoId1++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtApellidoNombre.Text = "";
            //txtId.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtIdPaciente.Text = "";
            txtMotivoConsulta.Text = "";
            comboBox1Medico.Text = "";


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
