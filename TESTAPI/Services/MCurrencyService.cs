using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Services
{
	public class MCurrencyService : IMCurrencyService
	{
		KALBEContext dbContext;

		public MCurrencyService(KALBEContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<MCurrency> GetMCurrency()
		{
			var mcurrency = dbContext.MCurrencys.ToList();
			return mcurrency;
		}

		public MCurrency GetMCurrencyById(string id)
		{
			var mcurrency = dbContext.MCurrencys.FirstOrDefault(x => x.CurrencyID == id);
			return mcurrency;
		}
	}
}
