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
	public class FeatureManager : IFeatureService
	{
		private readonly IFeatureDal _featuredal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featuredal = featureDal;
        }
        public void TAdd(Feature entity)
		{
			_featuredal.Add(entity);
		}

		public void TDelete(Feature entity)
		{
			_featuredal.Delete(entity);
		}

		public Feature TGetByID(int id)
		{
			return _featuredal.GetByID(id);
		}

		public List<Feature> TGetListAll()
		{
			return _featuredal.GetListAll();
		}

		public void TUpdate(Feature entity)
		{
			_featuredal.Update(entity);
		}
	}
}
