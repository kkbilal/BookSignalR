using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class FeatureMapping : Profile
	{
        public FeatureMapping()
        {
            CreateMap<Feature, UpdateFeatureDto>();
			CreateMap<Feature, GetFeatureDto>();

			CreateMap<Feature, ResultFeatureDto>();

			CreateMap<Feature, CreateFeatureDto>();
		}
    }
}
