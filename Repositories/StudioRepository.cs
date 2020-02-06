using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Repositories
{
    public class StudioRepository : IStudioRepository
    {
        public int StudioId { get; set; }
        public int StudioName { get; set; }


        /*public Film[] GetFilmsByStudioId(int studioid)
        {
            return Film[].Films.Where(r => r.StudioId == studioid);
        }*/

        public Studio[] GetAllStudiosAsync()
        {
            Studio[] Studios = {
               new Studio() { StudioId = 1, StudioName = "Studio1"},

               new Studio() { StudioId = 2, StudioName = "Studio2"},

               new Studio() { StudioId = 3, StudioName = "Studio3"},
            };

            return Studios;
        }

      

        public Studio GetStudioAsync(int id)
        {
            if (id == 1)
            {
                return new Studio() { StudioId = 1, StudioName = "Studio1" };
            }
            else if (id == 2)
            {
                return new Studio() { StudioId = 2, StudioName = "Studio2" };
            }
            else if (id == 3)
            {
                return new Studio() { StudioId = 3, StudioName = "Studio3" };
            }
            else
            {
                throw new Exception("Failure in GetStudioAsync");
            }
        }

        public Studio GetStudioByName(string name)
        {
            if (name == "Studio1")
            {
                return new Studio() { StudioId = 1, StudioName = "Studio1" };
            }
            else if (name == "Studio2")
            {
                return new Studio() { StudioId = 2, StudioName = "Studio2" };
            }
            else if (name == "Studio3")
            {
                return new Studio() { StudioId = 3, StudioName = "Studio3" };
            }
            else
            {
                throw new Exception("Failure in GetStudioAsync");
            }
        }
    }
}
