using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Models
{
    public class Studio
    {
            public int StudioId { get; set; }
            public string StudioName { get; set; }
            
            public IEnumerable<Film> Films { get; set; }
        
    }
}
