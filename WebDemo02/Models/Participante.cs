using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo02.Models
{
    public class Participante
    {
        public byte DNI { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno{ get; set; }
        public string ApellidoMaterno { get; set; }
        public string  sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string correo { get; set; }
        public Profesion PrfesionDeParticipante { get; set; }
        public Calificacion CalificaionDeParticipante { get; set; }


    }
}