using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrryGutierrezAriñez.Entities
{
    public class PeliculaFormCLS
    {
        // PROPIEDADES

        [Required (ErrorMessage = "Debe ingresar el Id")]
        public int Id { get; set; }

        [Required (ErrorMessage = "Debe ingresar el Titulo")]
        [MaxLength(150, ErrorMessage = "El titulo no debe tener mas de 150 caracteres")]
        public string Titulo { get; set; } = null!;

        [Required (ErrorMessage = "Debe ingresar el Resumen")]
        [MaxLength(200, ErrorMessage = "El resumen no debe tener mas de 2000 caracteres")]
        [MinLength(10, ErrorMessage = "El resumen no debe tener menos de 10 caracteres")]
        public string Resumen { get; set; } = null!;

    }
}
