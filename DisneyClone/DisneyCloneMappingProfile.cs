using AutoMapper;
using DisneyClone.Entities;
using DisneyClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyClone
{
    public class DisneyCloneMappingProfile : Profile
    {
        public DisneyCloneMappingProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
        }
    }
}
