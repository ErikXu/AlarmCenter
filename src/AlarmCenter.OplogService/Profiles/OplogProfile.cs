using AlarmCenter.Entities.Models;
using AlarmCenter.OplogService.Models;
using AutoMapper;

namespace AlarmCenter.OplogService.Profiles
{
    public class OplogProfile : Profile
    {
        public OplogProfile()
        {
            CreateMap<CreateForm, Oplog>();
        }
    }
}