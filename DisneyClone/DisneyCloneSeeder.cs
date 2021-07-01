using DisneyClone.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone
{
    public class DisneyCloneSeeder
    {
        private readonly DisneyCloneDbContext _dbContext;

        public DisneyCloneSeeder(DisneyCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {

                if (!_dbContext.Movies.Any())
                {
                    var movies = GetMovies();
                    _dbContext.Movies.AddRange(movies);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Auntie Edna",
                    Description = "When Bob Parr visits designer Edna Mode for help with his high-energy toddler, she pulls an all-nighter designing a supersuit to harness Jack-Jack’s seemingly limitless powers.",
                    BackgroundImage = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/09A0617D43282F1A4FA1A97DF6159B4263A8DEB9679A007B61D5E5D6E5D0A2DD/scale?width=1440&aspectRatio=1.78&format=jpeg",
                    CardImage = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/1E0501AFBAFCA1ABB5D31DBA7D1A913B2A35D70FD3DFD804939B71901577161D/scale?width=400&aspectRatio=1.78&format=jpeg",
                    TitleImage = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/E7D8EFFDD30B2A0E205DDD9929207439B21E7595709769F2A23C50457664FFB2/scale?width=1440&aspectRatio=1.78",
                    SubTitle = "2021 • 1h 52m • Family, Fantasy, Animation, Action-Adventure",
                    Type = "new"
                }
            };

            return movies;
        }

    }
}
