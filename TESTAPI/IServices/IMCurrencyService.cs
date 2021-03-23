using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.Models;

namespace TESTAPI.IServices
{
	public interface IMCurrencyService
	{
		IEnumerable<MCurrency> GetMCurrency();
		MCurrency GetMCurrencyById(string id);
	}
}
