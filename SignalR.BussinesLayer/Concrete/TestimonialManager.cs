using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testimonialdal;

		public TestimonialManager(ITestimonialDal testimonialdal)
		{
			_testimonialdal = testimonialdal;
		}

		public void TAdd(Testimonial entity)
		{
			_testimonialdal.Add(entity);
		}

		public void TDelete(Testimonial entity)
		{
			_testimonialdal.Delete(entity);
		}

		public Testimonial TGetByID(int id)
		{
			return _testimonialdal.GetByID(id);
		}

		public List<Testimonial> TGetListAll()
		{
			return _testimonialdal.GetListAll();
		}

		public void TUpdate(Testimonial entity)
		{
			_testimonialdal.Update(entity);
		}
	}
}
