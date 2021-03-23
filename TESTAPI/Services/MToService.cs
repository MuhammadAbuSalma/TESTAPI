using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Services
{
	public class MToService : IMToService
	{
		KALBEContext dbContext;
		public MToService(KALBEContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<MTo> GetMTo()
		{
			var mto = dbContext.MTos.ToList();
			return mto;
		}

		public MTo GetMToById(string id)
		{
			var mto = dbContext.MTos.FirstOrDefault(x => x.ToID.ToString() == id);
			return mto;
		}
	}
}
