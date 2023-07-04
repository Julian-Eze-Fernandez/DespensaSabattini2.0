using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespensaSabattini.BD.Data.Entity
{
    public class TipoPago
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El NOMBRE del PAGO es Obligatorio")]
        [MaxLength(15, ErrorMessage = "Solo se aceptan hasta 15 caracteres en el NOMBRE")]
        public string NombrePago { get; set; }
    }
}
