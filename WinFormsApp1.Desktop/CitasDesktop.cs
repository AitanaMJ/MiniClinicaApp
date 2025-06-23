using WinFormsApp1.Desktop.Models;

namespace WinFormsApp1.Desktop
{
    public partial class CitasDesktop : Form
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private int proximoId = 0;
        private int ultimoIdRegistrado = 0;
        //...................................
        private List<Cita> cita = new List<Cita>();
        private int proximoId1 = 0;
        private int ultimoIdRegistrado1 = 0;
        public CitasDesktop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int idpaciente = proximoId;
            string nombreyapellido = textBox1.Text;
            int edad = int.Parse(textBox2.Text);
            int dni = int.Parse(textBox3.Text);

            dataGridView1.Rows.Add(idpaciente, nombreyapellido, edad, dni);
            proximoId++;
            ultimoIdRegistrado = idpaciente;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal total;
            if (decimal.TryParse(textBox5.Text.Replace("$", "").Trim(), out total))
            {
                textBox5.Text = total.ToString("C");
            }

            int idcita = proximoId1;
            string motivo = textBox4.Text;
            string medico = comboBox1.Text;
            DateTime fecha = dateTimePicker1.Value;
            DateTime hora = dateTimePicker2.Value;


            dataGridView2.Rows.Add(idcita, motivo, medico, fecha.ToString("dd/MM/yyyy"), hora.ToString("HH:mm tt"), total.ToString("C"));
            proximoId1++;
            ultimoIdRegistrado1 = idcita;

            Cita nuevaCita = new Cita(idcita, motivo, fecha, hora, total, medico);

        }

        private void reciboDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo();
            int idActual = ultimoIdRegistrado;
            recibo.label9.Text = idActual.ToString("D6");
            recibo.label1.Text = this.textBox1.Text;
            recibo.label3.Text = this.textBox3.Text;
            recibo.label4.Text = this.dateTimePicker1.Value.ToString("dd/MM/yyyy");
            recibo.label5.Text = this.dateTimePicker2.Value.ToString("HH:mm tt");
            recibo.label6.Text = this.comboBox1.Text;
            recibo.label7.Text = this.textBox5.Text;

            string fechaEmision = DateTime.Now.ToString("dd/MM/yyyy 'a las' HH:mm tt");

            string reciboCita = $"Emitido el: {fechaEmision}\n" +
                "Atentamente,\n" +
                "CLÍNICA MÉDICA SANAR BIEN\n";
            recibo.label8.Text = reciboCita;
            this.Hide();
            recibo.Show();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
