using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ProductMapping : Profile
	{
        public ProductMapping()
        {
            CreateMap<Product,UpdateProductDto>();
			CreateMap<Product, CreateProductDto>();

			CreateMap<Product, GetProductDto>();
			CreateMap<Product, ResultProductDto>();
		}
    }
}
