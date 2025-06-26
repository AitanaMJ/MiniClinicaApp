using System.Text.Json;
using System.Net.Http.Json;
using MiniClinicaaApp2.Desktop.Models;
using MiniClinicaApp.Api.Migrations;
using MiniClinicaApp.Api.Models;
using Paciente = MiniClinicaaApp2.Desktop.Models.Paciente;

namespace MiniClinicaaApp2.Desktop
{
    public partial class CitasDesktop : Form
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7032/") // 
        };


        private List<Paciente> pacientes = new List<Paciente>();
        private int proximoId = 0;
        private int ultimoIdRegistrado = 0;
        //...................................
        private List<CitaDesktop> cita = new List<CitaDesktop>();
        private int proximoId1 = 0;
        private int ultimoIdRegistrado1 = 0;
        public CitasDesktop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task CargarMedicosEnComboBoxAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7032/"); // 

                var medicos = await client.GetFromJsonAsync<List<MedicoDesktop>>("api/Medico");

                // Insertar opción "Todos"
                medicos.Insert(0, new MedicoDesktop { Id = 0, Nombre = "Todos" });

                cmbFiltroMedico.DataSource = medicos;
                cmbFiltroMedico.DisplayMember = "Nombre";
                cmbFiltroMedico.ValueMember = "Id";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var nuevoPaciente = new Paciente
            {
                NombreyApellido = textBox1.Text,
                Edad = int.Parse(textBox2.Text),
                dni = int.Parse(textBox3.Text)
            };

            try
            {
                var response = await client.PostAsJsonAsync("api/Paciente/Crear", nuevoPaciente);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Paciente registrado con éxito.");
                    await CargarPacientes();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al registrar paciente: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }


        }

        private async Task CargarPacientes()
        {
            try
            {
                var pacientes = await client.GetFromJsonAsync<List<Paciente>>("api/Paciente/Lista");
                dataGridView1.DataSource = pacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            var cita = new
            {
                MotivoConsulta = textBox4.Text,
                Fecha = dateTimePicker1.Value,
                Hora = dateTimePicker2.Value.TimeOfDay,
                PrecioConsulta = decimal.Parse(textBox5.Text),
                MedicoId = (int)comboBoxMedicos.SelectedValue
            };

            try
            {
                var response = await client.PostAsJsonAsync("api/Cita/Crear", cita);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cita registrada con éxito.");
                    await CargarCitas();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al registrar cita: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }

        }

        private async Task CargarCitas()
        {
            try
            {
                var citas = await client.GetFromJsonAsync<List<CitaDesktop>>("api/Cita/Lista");
                dataGridView2.DataSource = citas.Select(c => new
                {
                    c.Id,
                    c.MotivoConsulta,
                    Fecha = c.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    Hora = c.Hora.ToString(@"hh\:mm"),
                    Precio = c.PrecioConsulta.ToString("C"),
                    Medico = c.Medico?.Nombre ?? "Sin médico"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void CitasDesktop_Load(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetAsync("api/Medico");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var listaMedicos = JsonSerializer.Deserialize<List<Medico>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                comboBoxMedicos.DataSource = listaMedicos;
                comboBoxMedicos.DisplayMember = "Nombre";
                comboBoxMedicos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }

            await CargarCitas();
            await CargarPacientes();
            await CargarMedicosEnComboBoxAsync();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int pacienteId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                var confirmacion = MessageBox.Show("¿Estás seguro de eliminar este paciente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    var response = await client.DeleteAsync($"api/Paciente/Eliminar/{pacienteId}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente eliminado.");
                        await CargarPacientes();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error: " + error);
                    }
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int citaId = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Id"].Value);

                var confirmacion = MessageBox.Show("¿Estás seguro de eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    var response = await client.DeleteAsync($"api/Cita/Eliminar/{citaId}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cita eliminada.");
                        await CargarCitas();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error: " + error);
                    }
                }
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                var pacienteEditado = new Paciente
                {
                    Id = id,
                    NombreyApellido = textBox1.Text,
                    Edad = int.Parse(textBox2.Text),
                    dni = int.Parse(textBox3.Text)
                };

                var response = await client.PutAsJsonAsync($"api/Paciente/Editar/{id}", pacienteEditado);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Paciente editado correctamente.");
                    await CargarPacientes();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al editar: " + error);
                }
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Id"].Value);

                var citaEditada = new CitaDesktop
                {
                    Id = id,
                    MotivoConsulta = textBox4.Text,
                    Fecha = dateTimePicker1.Value,
                    PrecioConsulta = decimal.Parse(textBox5.Text),
                    MedicoId = (int)comboBoxMedicos.SelectedValue
                };

                var response = await client.PutAsJsonAsync($"api/Cita/Editar/{id}", citaEditada);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cita editada correctamente.");
                    await CargarCitas();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al editar cita: " + error);
                }
            }
        }

        private async void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                var todasLasCitas = await client.GetFromJsonAsync<List<CitaDesktop>>("api/Cita/Lista");

                var fechaSeleccionada = dtpFiltroFecha.Value.Date;
                var medicoIdSeleccionado = (int?)cmbFiltroMedico.SelectedValue;

                var filtro = todasLasCitas
                    .Where(c => c.Fecha.Date == fechaSeleccionada)
                    .Where(c => medicoIdSeleccionado == null || c.MedicoId == medicoIdSeleccionado)
                    .ToList();

                dataGridView3.DataSource = filtro.Select(c => new
                {
                    c.Id,
                    c.MotivoConsulta,
                    Fecha = c.Fecha.Add(c.Hora).ToString("dd/MM/yyyy HH:mm"),
                    Precio = c.PrecioConsulta.ToString("C"),
                    Medico = c.Medico?.Nombre ?? "Sin médico"
                }).ToList();

                lblTotalCitas.Text = "Total de citas: " + filtro.Count;
                lblTotalFacturado.Text = "Total facturado: " + filtro.Sum(c => c.PrecioConsulta).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message);
            }
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
