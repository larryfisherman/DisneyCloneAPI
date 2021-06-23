using AutoMapper;
using DisneyClone.Entities;
using DisneyClone.Exceptions;
using DisneyClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone.Services
{

    public interface IMoviesService
    {
        IEnumerable<Movie> GetAllMovies();
        public int Create(MovieDto dto);
        public void Delete(int id);
    }

    public class MoviesService : IMoviesService
    {
        private readonly DisneyCloneDbContext _dbContext;
        private readonly IMapper _mapper;   


        public MoviesService(DisneyCloneDbContext dbContext, IMapper mapper)
        {

            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _dbContext.Movies.ToList();
            var result = _mapper.Map<List<Movie>>(movies);

            return result;
        }


        public int Create(MovieDto dto)
        {
            var movie = _mapper.Map<Movie>(dto);
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            return movie.Id;
        }

        public void Delete(int id)
        {
            var movie = _dbContext.Movies.FirstOrDefault(m => m.Id == id);

            if (movie is null) throw new NotFoundException("Movie not found");

            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();
        }
    }
}
