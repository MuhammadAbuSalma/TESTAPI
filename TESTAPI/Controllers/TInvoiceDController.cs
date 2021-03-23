using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTAPI.IServices;
using TESTAPI.Models;

namespace TESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TInvoiceDController : ControllerBase
    {
        private readonly ITInvoiceDService tinvoicedService;
        public TInvoiceDController(ITInvoiceDService tinvoiced)
        {
            tinvoicedService = tinvoiced;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TInvoiceD/GetTInvoiceD")]
        public IEnumerable<TInvoiceD> GetTInvoiceD()
        {
            return tinvoicedService.GetTInvoiceD();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/TInvoiceD/AddTInvoiceD")]
        public TInvoiceD AddTInvoiceD(TInvoiceD tinvoiced)
        {
            return tinvoicedService.AddTInvoiceD(tinvoiced);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/TInvoiceD/UpdateTInvoiceD")]
        public TInvoiceD UpdateTInvoiceD(TInvoiceD tinvoiced)
        {
            return tinvoicedService.UpdateTInvoiceD(tinvoiced);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/TInvoiceD/DeleteTInvoiceD")]
        public TInvoiceD DeleteTInvoiceD(string id)
        {
            return tinvoicedService.DeleteTInvoiceD(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TInvoiceD/GetTInvoiceDById")]
        public IEnumerable<TInvoiceD> GetTInvoiceDById(string id)
        {
            return tinvoicedService.GetTInvoiceDById(id);
        }
    }
}