using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SocialMediaMapping : Profile
	{
		public SocialMediaMapping()
		{
			CreateMap<SocialMedia, UpdateSocialMediaDto>();
			CreateMap<SocialMedia, GetSocialMediaDto>();
			CreateMap<SocialMedia, CreateSocialMediaDto>();
			CreateMap<SocialMedia, ResultSocialMediaDto>();
		}
	}
}
