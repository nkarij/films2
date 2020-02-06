using Microsoft.AspNetCore.Mvc;
using Nanna_film.Models;
using Nanna_film.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudiosController: ControllerBase
    {
        private readonly IStudioRepository _studioRepository;

        public StudiosController(IStudioRepository studioRepository)
        {
            _studioRepository = studioRepository;
        }

        [HttpGet]
        public ActionResult<Studio[]> GetAllStudios()
        {
            var result = _studioRepository.GetAllStudiosAsync();
            return result;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Studio> GetStudio(int id)
        {
            var result = _studioRepository.GetStudioAsync(id);
            return result;
        }

        [HttpGet("{name}")]
        public ActionResult<Studio> GetStudioByName(string name)
        {
            var result = _studioRepository.GetStudioByName(name);
            return result;
        }
    }
}
