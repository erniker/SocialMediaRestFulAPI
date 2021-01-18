using AutoMapper;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
            // las dolineas de arriba se pueden poner tambien como la que hay a continuacion
            CreateMap<Security, SecurityDto>().ReverseMap();
        }

    }
}
