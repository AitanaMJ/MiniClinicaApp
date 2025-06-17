using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinicaApp1.Desktop.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string MotivoConsulta { get; set; }
        public string Medicos { get; set; } = "";

        public decimal Total { get; set; }
        //public Paciente? Paciente { get; set; }

        public Cita(int idCita, string motivo, DateTime fecha, DateTime hora, decimal total, string medico)
        {
            IdCita = idCita;
            MotivoConsulta = motivo;
            Fecha = fecha;
            Hora = hora;
            Total = total;
            Medicos = medico;
        }
    }

     
    }
