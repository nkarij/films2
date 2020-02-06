using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Models
{
    public class Film
    {
            public string Id { get; set; }
            public string Name { get; set; }
            public string NumberOfFilms { get; set; } // 8
            // public int NumberInStudios { get; set; }
            public string NumberOfBorrowers { get; set; } //

            public IEnumerable<Studio> Studios { get; set; }
      
    }
}

