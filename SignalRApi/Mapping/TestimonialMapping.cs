using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class TestimonialMapping :Profile
	{
        public TestimonialMapping()
        {
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
			CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
		}
    }
}
