using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.Models;

namespace TESTAPI.IServices
{
	public interface ITInvoiceHService
	{
		IEnumerable<TInvoiceH> GetTInvoiceH();
		TInvoiceH AddTInvoiceH(TInvoiceH tinvoiceh);
		TInvoiceH UpdateTInvoiceH(TInvoiceH tinvoiceh);
		TInvoiceH DeleteTInvoiceH(string id);
		TInvoiceH GetTInvoiceHById(string id);
		string CountTInvoiceH();
	}
}
