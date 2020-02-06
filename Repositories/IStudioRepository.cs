using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Repositories
{
    public interface IStudioRepository
    {
        Studio[] GetAllStudiosAsync();
        Studio GetStudioAsync(int id);
        Studio GetStudioByName(string name);
    }
}