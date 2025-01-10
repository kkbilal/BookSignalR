using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SocialMediaMapping : Profile
	{
		public SocialMediaMapping()
		{
			CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
			CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
		}
	}
}
