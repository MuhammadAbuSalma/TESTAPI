using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.Models;

namespace TESTAPI.IServices
{
	public interface IMPoService
	{
		IEnumerable<MPo> GetMPo();
		MPo GetMPoById(string id);
	}
}
