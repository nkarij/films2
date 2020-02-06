using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Nanna_film.Repositories
{
    public interface IFilmRepository
    {


        IEnumerable<Film> GetAllFilmsAsync();

        Film GetFilmAsync(string id);

        Film CreateFilm(string name);

        Film ChangeNumber(string number, string id);

        // Film GetFilmByStudioId(int studioId);
    }
}
