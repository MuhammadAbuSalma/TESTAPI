using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Services
{
	public class MPoService : IMPoService
	{
		KALBEContext dbContext;
		public MPoService(KALBEContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<MPo> GetMPo()
		{
			var mpo = dbContext.MPos.ToList();
			return mpo;
		}

		public MPo GetMPoById(string id)
		{
			var mpo = dbContext.MPos.FirstOrDefault(x => x.PONo == id);
			return mpo;
		}
	}
}
