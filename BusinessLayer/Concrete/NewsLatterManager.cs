
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLatterManager:INewsLatterService
	{
		INewsLatterDal _newLatterDal;

		public NewsLatterManager(INewsLatterDal newLatterDal)
		{
			_newLatterDal = newLatterDal;
		}

		public void AddNewsLatter(NewsLatter newslatter)
		{
			_newLatterDal.Insert(newslatter);
		}
	}
}
