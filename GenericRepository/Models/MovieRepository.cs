using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepository.Models
{
    public class MovieRepository :  Repository<Movie, MovieContext>, IRepository<Movie>
    {

    }
}