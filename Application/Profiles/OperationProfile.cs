using Application.Models;
using AutoMapper;
using Core.Entities;

namespace Application.Profiles
{
    public class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<Operation, OperationDto>();
        }
    }
}
