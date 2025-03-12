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
			_tablemenudal.Add(entity);
		}

		public void TDelete(TableMenu entity)
		{
			_tablemenudal.Delete(entity);
		}

		public TableMenu TGetByID(int id)
		{
			var value = _tablemenudal.GetByID(id);
			return value;
		}

		public List<TableMenu> TGetListAll()
		{
			var value = _tablemenudal.GetListAll();
			return value;
		}

		public int TTableMenuCount()
		{
			return _tablemenudal.TableMenuCount();
		}

		public void TUpdate(TableMenu entity)
		{
			_tablemenudal.Update(entity);
		}
	}
}
