using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PracticeDTO.Dtos;
using PracticeDTO.Models;

namespace PracticeDTO.MapConfiguration
{
    public class MapProfile : Profile
    {
        public Mapper GetMapper()
        {
            var cng = new MapperConfiguration(c =>
            {
                c.CreateMap<Users, UsersDto>().ForMember
                (destenation => destenation.Name,
                act => act.MapFrom(source => source.UserName));
                c.CreateMap<UsersDto, Users>();
            });
            var mapper = new Mapper(cng);
            return mapper;
        }
    }
}