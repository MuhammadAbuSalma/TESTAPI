using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Services
{
	public class TInvoiceDService : ITInvoiceDService
	{
		KALBEContext dbContext;
		public TInvoiceDService(KALBEContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<TInvoiceD> GetTInvoiceD()
		{
			var tinvoiced = dbContext.TInvoiceDs.ToList();
			return tinvoiced;
		}

		public TInvoiceD AddTInvoiceD(TInvoiceD tinvoiced)
		{
			if (tinvoiced != null)
			{
				dbContext.TInvoiceDs.Add(tinvoiced);
				dbContext.SaveChanges();
				return tinvoiced;
			}
			return null;
		}

		public TInvoiceD UpdateTInvoiceD(TInvoiceD tinvoiced)
		{

			dbContext.Entry(tinvoiced).State = EntityState.Modified;
			dbContext.SaveChanges();
			return tinvoiced;
		}

		public TInvoiceD DeleteTInvoiceD(string id)
		{
			var tinvoiced = dbContext.TInvoiceDs.FirstOrDefault(x => x.InvoiceHID == id);
			dbContext.Entry(tinvoiced).State = EntityState.Deleted;
			dbContext.SaveChanges();
			return tinvoiced;
		}

		public IEnumerable<TInvoiceD> GetTInvoiceDById(string id)
		{
			var tinvoiced = dbContext.TInvoiceDs.Where(x => x.InvoiceHID == id).ToList();
			return tinvoiced;
		}
	}
}