using HenrryGutierrezAriñez.Entities;

namespace HenrryGutierrezAriñez.Client.Services
{
    public class PeliculaService
    {
        private List<PeliculaListCLS> lista;

        public PeliculaService()
        {
            lista = new List<PeliculaListCLS>();
            lista.Add(new PeliculaListCLS { Id = 1, Titulo = "Pelicula 1" });
            lista.Add(new PeliculaListCLS { Id = 2, Titulo = "Pelicula 2" });
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
    }
}
