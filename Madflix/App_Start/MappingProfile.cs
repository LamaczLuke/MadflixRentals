using AutoMapper;
using Madflix.Dtos;
using Madflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Madflix.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //database to Dto ----syntax ("Source","Target")
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //Dto to database
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore()); ;
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore()); ;


        }

    }
}