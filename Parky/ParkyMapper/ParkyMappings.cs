using AutoMapper;
using Parky.Models;
using Parky.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.ParkyMapper
{
    public class ParkyMappings : Profile 
    {

        public ParkyMappings()
        {

            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
            CreateMap<Trail, TrailDto>().ReverseMap();
            CreateMap<Trail, TrailCreateDto>().ReverseMap();
            CreateMap<Trail, TrailUpdateDto>().ReverseMap();
           
        }

    }
}
