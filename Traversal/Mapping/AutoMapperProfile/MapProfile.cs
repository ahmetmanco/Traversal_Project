using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace Traversal.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //CreateMap<AnnouncementAddDTO, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTO>().ReverseMap(); 

            
            CreateMap<AppUser, AppUserRegisterDTO>().ReverseMap(); 

            
            CreateMap<AppUser, AppUserLoginDTO>().ReverseMap(); 

            
            CreateMap<Announcement, AnnouncementListDTO>().ReverseMap(); 

            
            CreateMap<Announcement, AnnouncementUpdateDTO>().ReverseMap();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();


        }
    }
}
