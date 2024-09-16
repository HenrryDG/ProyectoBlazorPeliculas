using HenrryGutierrezAriñez.Entities;

namespace HenrryGutierrezAriñez.Client.Services
{
    public class TipoPeliculaService
    {
        private List<TipoPeliculaCLS> lista;
        public TipoPeliculaService()
        {
            lista = new List<TipoPeliculaCLS>();
            lista.Add(new TipoPeliculaCLS { IdTipo = 1, NombreTipo = "Accion" });
            lista.Add(new TipoPeliculaCLS { IdTipo = 2, NombreTipo = "Terror" });
        }

        public List<TipoPeliculaCLS> ListarTipoPeliculas()
        {
            return lista;
        }

        public int ObtenerIdTipoLibro(string nombreTipo)
        {
            var obj = lista.Where(p => p.NombreTipo == nombreTipo).FirstOrDefault();
            
            if (obj != null)
            {
                return obj.IdTipo;
            }
            else
            {
                return 0;
            }
            
        }

        public string ObtenerNombreTipoLibro(int idTipo)
        {
            var obj = lista.Where(p => p.IdTipo == idTipo).FirstOrDefault();
            
            if (obj != null)
            {
                return obj.NombreTipo;
            }
            else
            {
                return "";
            }
        }
    }
}
