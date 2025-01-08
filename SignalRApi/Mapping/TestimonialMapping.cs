using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class TestimonialMapping :Profile
	{
        public TestimonialMapping()
        {
            CreateMap<Testimonial, UpdateTestimonialDto>();
			CreateMap<Testimonial, GetTestimonialDto>();
			CreateMap<Testimonial, ResultTestimonialDto>();
			CreateMap<Testimonial, CreateTestimonialDto>();
		}
    }
}
