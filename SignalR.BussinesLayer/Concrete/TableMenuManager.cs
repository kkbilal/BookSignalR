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
	public class TableMenuManager : ITableMenuService
	{
		private readonly ITableMenuDal _tablemenudal;

		public TableMenuManager(ITableMenuDal tablemenudal)
		{
			_tablemenudal = tablemenudal;
		}

		public void TAdd(TableMenu entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(TableMenu entity)
		{
			throw new NotImplementedException();
		}

		public TableMenu TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<TableMenu> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public int TTableMenuCount()
		{
			return _tablemenudal.TableMenuCount();
		}

		public void TUpdate(TableMenu entity)
		{
			throw new NotImplementedException();
		}
	}
}
