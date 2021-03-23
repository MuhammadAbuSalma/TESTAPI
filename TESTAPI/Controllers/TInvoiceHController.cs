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
    public class TInvoiceHController : ControllerBase
    {
        private readonly ITInvoiceHService tinvoicehService;
        public TInvoiceHController(ITInvoiceHService tinvoiceh)
        {
            tinvoicehService = tinvoiceh;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TInvoiceH/GetTInvoiceH")]
        public IEnumerable<TInvoiceH> GetTInvoiceH()
        {
            return tinvoicehService.GetTInvoiceH();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/TInvoiceH/AddTInvoiceH")]
        public TInvoiceH AddTInvoiceH(TInvoiceH tinvoiceh)
        {
            return tinvoicehService.AddTInvoiceH(tinvoiceh);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/TInvoiceH/UpdateTInvoiceH")]
        public TInvoiceH UpdateTInvoiceH(TInvoiceH tinvoiceh)
        {
            return tinvoicehService.UpdateTInvoiceH(tinvoiceh);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/TInvoiceH/DeleteTInvoiceH")]
        public TInvoiceH DeleteTInvoiceH(string id)
        {
            return tinvoicehService.DeleteTInvoiceH(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TInvoiceH/GetTInvoiceHById")]
        public TInvoiceH GetTInvoiceHById(string id)
        {
            return tinvoicehService.GetTInvoiceHById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/TInvoiceH/CountTInvoiceH")]
        public string CountTInvoiceH()
        {
            return tinvoicehService.CountTInvoiceH();
        }
    }
}