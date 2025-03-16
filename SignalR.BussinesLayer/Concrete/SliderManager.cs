﻿using SignalR.BussinesLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
	public class SliderManager : ISliderService
	{
		private readonly ISliderDal _sliderDal;

		public SliderManager(ISliderDal sliderdal)
		{
			_sliderDal = sliderdal;
		}

		public void TAdd(Slider entity)
		{
			_sliderDal.Add(entity);
		}

		public void TDelete(Slider entity)
		{
			_sliderDal.Delete(entity);
		}

		public Slider TGetByID(int id)
		{
			return _sliderDal.GetByID(id);
		}

		public List<Slider> TGetListAll()
		{
			return _sliderDal.GetListAll();
		}

		public void TUpdate(Slider entity)
		{
			_sliderDal.Update(entity);
		}
	}
}
