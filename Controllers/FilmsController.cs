using System;
using System.Net;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nanna_film.Models;
using Nanna_film.Repositories;
using AutoMapper;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nanna_film.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IMapper _mapper;

        public FilmsController(IFilmRepository filmRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Film>> GetAllFilms()
        {
            IEnumerable<Film> result = _filmRepository.GetAllFilmsAsync();
            return result.ToList();
        }


        /* [HttpGet]
         public ActionResult<Film[]> GetAllFilms()
         {
             return null;
             //Film film = new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberOfBorrowers = 1 };
             //var result = _filmRepository.GetAllFilmsAsync();
             //return film;
         //return result;
     }*/

        
        [HttpPost("{id}")]
        public ActionResult<Film> BorrowFilm(string id)
        {
            var result = _filmRepository.GetFilmAsync(id);
            return result;
            //tjekker om filmen kan lånes.
            //var studios = result.Studios.Count();
            //if (studios >= result.NumberOfFilms)
            //{
            //    message = "There are no more films available";
            //    return message;
            //}
            //else
            //{
            //    message = "You have chosenn film:" + result.Name;
            //    return message;
            //}
        }

        // will create a new film with an name. 
        //[HttpPost("{name}")]
        //public ActionResult<Film> CreateNewFilm(string name)
        //{
        //    var film = _mapper.Map<Film>(newfilm);
        //    var film = _filmRepository.CreateFilm(name);
        //    return film;
        //    return Ok();
        //}

        [HttpPost]
        public ActionResult<Film> CreateNewFilm([FromBody] Film model)
        {
            //var film = _mapper.Map<Film>(newfilm);
            var film = model;
            //var film = _filmRepository.CreateFilm(name);
            return film;
            //return Ok();
        }

        [HttpPost]
        public ActionResult<int> ChangeNumberOfFilms(int id, int number = 0)
        {
            var what = number;
            //string param1 = HttpUtility.ParseQueryString(myUri.Query).Get("param1");
            // var film = _mapper.Map<Film>(newfilm);
            //var film = _filmRepository.ChangeNumber();
            //return Ok();
            return what;
        }

        /*[HttpPost]
        public ActionResult<Film> Post(Film newfilm)
        {
            var film = _mapper.Map<Film>(newfilm);
           _filmRepository.AddFilm(film);
            return Ok();
        }*/

        //[HttpGet("{name}")]
        //public ActionResult<Film> GetFilmByName(string name)
        //{
        //    var result = _filmRepository.GetFilmByName(name);
        //     return result;
        // }


    }
}
