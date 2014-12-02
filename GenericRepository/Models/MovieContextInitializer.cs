using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GenericRepository.Models
{
    public class MovieContextInitializer : CreateDatabaseIfNotExists<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            context.Movies.Add(new Movie
            {
                Name = "Gone with the wind",
                TicketPrice = 3.55M
            });
            context.Movies.Add(new Movie
            {
                Name = "Black and blue",
                TicketPrice = 12.55M
            });
            base.Seed(context);
        }
    }
}