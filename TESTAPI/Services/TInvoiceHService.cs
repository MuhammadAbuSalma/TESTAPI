using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Services
{
	public class TInvoiceHService : ITInvoiceHService
	{
		KALBEContext dbContext;
		public TInvoiceHService(KALBEContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<TInvoiceH> GetTInvoiceH()
		{
			var tinvoiceh = dbContext.TInvoiceHs.ToList();
			return tinvoiceh;
		}

		public TInvoiceH AddTInvoiceH(TInvoiceH tinvoiceh)
		{
			if (tinvoiceh != null)
			{
				dbContext.TInvoiceHs.Add(tinvoiceh);
				dbContext.SaveChanges();
				return tinvoiceh;
			}
			return null;
		}

		public TInvoiceH UpdateTInvoiceH(TInvoiceH tinvoiceh)
		{

			dbContext.Entry(tinvoiceh).State = EntityState.Modified;
			dbContext.SaveChanges();
			return tinvoiceh;
		}

		public TInvoiceH DeleteTInvoiceH(string id)
		{
			var tinvoiceh = dbContext.TInvoiceHs.FirstOrDefault(x => x.InvoiceHID == id);
			dbContext.Entry(tinvoiceh).State = EntityState.Deleted;
			dbContext.SaveChanges();
			return tinvoiceh;
		}

		public TInvoiceH GetTInvoiceHById(string id)
		{
			var tinvoiceh = dbContext.TInvoiceHs.FirstOrDefault(x => x.InvoiceHID == id);
			return tinvoiceh;
		}

		public string CountTInvoiceH()
		{
			var total = dbContext.TInvoiceHs.ToList().Count().ToString();
			return total;
		}
	}
}
