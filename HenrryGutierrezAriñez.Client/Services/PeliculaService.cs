using HenrryGutierrezAriñez.Entities;

namespace HenrryGutierrezAriñez.Client.Services
{
    public class PeliculaService
    {
        private List<PeliculaListCLS> lista;

        private TipoPeliculaService tipoPeliculaService;

        public PeliculaService(TipoPeliculaService _tipoPeliculaService)
        {
            tipoPeliculaService = _tipoPeliculaService;
            lista = new List<PeliculaListCLS>();
            lista.Add(new PeliculaListCLS { Id = 1, Titulo = "Spider-Man", NombreTipo = "Accion" });
            lista.Add(new PeliculaListCLS { Id = 2, Titulo = "Coraline", NombreTipo = "Terror" });
        }

        public List<PeliculaListCLS> ListarPeliculas()
        {
            return lista;
        }

        public void EliminarPelicula(int id)
        {
            var listaQueda = lista.Where(p => p.Id != id).ToList();
            lista = listaQueda;
        }

        public PeliculaFormCLS RecuperarPeliculaPorId(int idPelicula)
        {
            var obj = lista.Where(p => p.Id == idPelicula).FirstOrDefault();

            if (obj != null)
            {
                return new PeliculaFormCLS { Id = obj.Id, Titulo = obj.Titulo, Resumen = "Resumen", IdTipo = tipoPeliculaService.ObtenerIdTipoLibro(obj.NombreTipo), Image = obj.Imagen };
            }
            else
            {
                return new PeliculaFormCLS();
            }
        }

        public void GuardarPelicula(PeliculaFormCLS oPeliculaFormCLS)
        {
            if (oPeliculaFormCLS.Id == 0)
            {
                int IdPelicula = lista.Select(p => p.Id).Max() + 1;

                lista.Add(new PeliculaListCLS { Id = IdPelicula, Titulo = oPeliculaFormCLS.Titulo, NombreTipo = tipoPeliculaService.ObtenerNombreTipoLibro(oPeliculaFormCLS.IdTipo), Imagen = oPeliculaFormCLS.Image });
            }
            else
            {
                var obj = lista.Where(p => p.Id == oPeliculaFormCLS.Id).FirstOrDefault();
                if (obj != null)
                {
                    obj.Titulo = oPeliculaFormCLS.Titulo;
                    obj.NombreTipo = tipoPeliculaService.ObtenerNombreTipoLibro(oPeliculaFormCLS.IdTipo);
                    obj.Imagen = oPeliculaFormCLS.Image;
                }
            }
           
        }
    }
}
