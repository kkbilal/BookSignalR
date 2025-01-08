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
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal _socialmediadal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialmediadal = socialMediaDal;
        }

        public void TAdd(SocialMedia entity)
		{
			_socialmediadal.Add(entity);
		}

		public void TDelete(SocialMedia entity)
		{
			_socialmediadal.Delete(entity);
		}

		public SocialMedia TGetByID(int id)
		{
			return _socialmediadal.GetByID(id);
		}

		public List<SocialMedia> TGetListAll()
		{
			return _socialmediadal.GetListAll();
		}

		public void TUpdate(SocialMedia entity)
		{
			_socialmediadal.Update(entity);
		}
	}
}
