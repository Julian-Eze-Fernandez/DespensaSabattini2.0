using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespensaSabattini.BD.Data.Entity
{
    public class Pago
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La DESCRIPCIÓN es Obligatoria")]
        [MaxLength(250, ErrorMessage = "Solo se aceptan hasta 250 caracteres en la DESCRIPCIÓN")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El MONTO es Obligatorio")]
        public double monto { get; set; }
    }
}
