//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDemo02
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPago
    {
        public int Numero { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal Monto { get; set; }
        public string DNIParticipante { get; set; }
    
        public virtual tblParticipante tblParticipante { get; set; }
    }
}
