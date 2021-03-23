using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.Models;

namespace TESTAPI.IServices
{
	public interface ITInvoiceDService
	{
		IEnumerable<TInvoiceD> GetTInvoiceD();
		TInvoiceD AddTInvoiceD(TInvoiceD tinvoiced);
		TInvoiceD UpdateTInvoiceD(TInvoiceD tinvoiced);
		TInvoiceD DeleteTInvoiceD(string id);
		IEnumerable<TInvoiceD> GetTInvoiceDById(string id);
	}
}
