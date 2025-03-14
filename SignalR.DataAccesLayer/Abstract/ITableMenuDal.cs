﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccesLayer.Abstract
{
	public interface ITableMenuDal : IGenericDal<TableMenu>
	{
		int TableMenuCount();
	}
}
