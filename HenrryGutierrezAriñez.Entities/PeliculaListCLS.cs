using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenrryGutierrezAriñez.Entities
{
    public class PeliculaListCLS
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;

        public string NombreTipo { get; set; } = string.Empty;

        public byte[]? Imagen { get; set; }

    }
}
