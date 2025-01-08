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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categorydal;

		public CategoryManager(ICategoryDal categorydal)
		{
			_categorydal = categorydal;
		}

		public void TAdd(Category entity)
		{
			_categorydal.Add(entity);
		}

		public void TDelete(Category entity)
		{
			_categorydal.Delete(entity);
		}

		public Category TGetByID(int id)
		{
			return _categorydal.GetByID(id);
		}

		public List<Category> TGetListAll()
		{
			return _categorydal.GetListAll(); 
		}

		public void TUpdate(Category entity)
		{
			_categorydal.Update(entity);
		}
	}
}
