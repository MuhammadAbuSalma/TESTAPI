using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTAPI.IServices;
using TESTAPI.Models;
using TESTAPI.Services;

namespace TESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCurrencyController : ControllerBase
    {
        private readonly IMCurrencyService mcurrencyService;
        public MCurrencyController(IMCurrencyService mcurrency)
        {
            mcurrencyService = mcurrency;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MCurrency/GetMCurrency")]
        public IEnumerable<MCurrency> GetMCurrency()
        {
            return mcurrencyService.GetMCurrency();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MCurrency/GetMCurrencyById")]
        public MCurrency GetMCurrencyById(string id)
        {
            return mcurrencyService.GetMCurrencyById(id);
        }
    }
}