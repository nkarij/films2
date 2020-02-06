using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Nanna_film.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int[] Films { get; set; }

        public int Counter { get; set; }

        public IEnumerable<Film> Films { get; set; }

    //public Studio[] {get;set;}

    public IEnumerable<Film> GetAllFilmsAsync()
        {
            IEnumerable<Film> Films = new List<Film>() {
                new Film() { Id = "1", Name = "Film1", NumberOfFilms = "4", NumberOfBorrowers = "1" },

                new Film() { Id = "2", Name = "Film2", NumberOfFilms = "2", NumberOfBorrowers = "1" },

                new Film() { Id = "3", Name = "Film3", NumberOfFilms = "5", NumberOfBorrowers = "1" },
            };
            return Films;
        }

        public Film GetFilmAsync(string id)
        {

            var films = this.GetAllFilmsAsync();
            Film film = null;
            foreach (var item in films)
            {
                if (item.Id == id)
                {
                    film = item;
                    return film;
                } 
                return item;
            }

            return film;
            //if (id == 1)
            //{
            //    return new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberOfBorrowers = 1 };
            //}
            //else if (id == 2)
            //{
            //    return new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberOfBorrowers = 1 };
            //}
            //else if (id == 3)
            //{
            //    return new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberOfBorrowers = 1 };
            //}
            //else
            //{
            //    throw new Exception("Failure in GetFilmAsync");
            //}
        }

        public Film CreateFilm(string name)
        {
 
            var film = new Film { Id = "4", Name = name, NumberOfFilms = "0", NumberOfBorrowers = "0", Studios = null };
            var films = this.GetAllFilmsAsync().ToList();
            films.Add(film);
            return film;
        }

        public Film ChangeNumber(string number, string id)
        {
            var film = this.GetFilmAsync(id);
            film.NumberOfBorrowers = number;
            return film;
        }

        public Film GetFilmByName(string name)
        {
            if (name == "Film1")
            {
                return new Film() { Id = "1", Name = "Film1", NumberOfFilms = "4", NumberOfBorrowers = "1" };
            }
            else if (name == "Film2")
            {
                return new Film() { Id = "2", Name = "Film2", NumberOfFilms = "2", NumberOfBorrowers = "1" };
            }
            else if (name == "Film3")
            {
                return new Film() { Id = "3", Name = "Film3", NumberOfFilms = "5", NumberOfBorrowers = "1" };
            }
            else
            {
                throw new Exception("Failure in GetFilmAsync");
            }
        }

    }
}


        /*public Film GetFilmByStudioIdint (string studioId)
        {
            if (studioId == "Studio1")
            {
                return new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberInStudios = 3 };
            }
            else if (name == "Film2")
            {
                return new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberInStudios = 2 };
            }
            else if (name == "Film3")
            {
                return new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberInStudios = 1 };
            }
            else
            {
                throw new Exception("Failure in GetFilmAsync");
            }
        }*/