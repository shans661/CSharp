using System.Linq;
using AutoMapper;
using DatingApp.API.Entities;
using DatingApp.DTOs;
using DatingApp.Extensions;
using DatingDatingApp.API.Entities;

namespace DatingApp.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotoDTO>();

            CreateMap<MemberUpdateDTO, AppUser>();

            CreateMap<RegisterDTO, AppUser>();

            CreateMap<Message,MessageDTO>()
            .ForMember(dest => dest.SenderPhotoUrl, src => src.MapFrom(x => x.Recipient.Photos.FirstOrDefault(x =>x.IsMain).Url))
            .ForMember(dest => dest.RecipientPhotoUrl, src => src.MapFrom(x => x.Recipient.Photos.FirstOrDefault(x => x.IsMain).Url));
        }
    }
}