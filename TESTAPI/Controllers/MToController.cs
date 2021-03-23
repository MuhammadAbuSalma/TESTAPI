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
    public class MToController : ControllerBase
    {
        private readonly IMToService mtoService;
        public MToController(IMToService mto)
        {
            mtoService = mto;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MTo/GetMTo")]
        public IEnumerable<MTo> GetMTo()
        {
            return mtoService.GetMTo();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MTo/GetMToById")]
        public MTo GetMToById(string id)
        {
            return mtoService.GetMToById(id);
        }
    }
}