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
    public class MPoController : ControllerBase
    {
        private readonly IMPoService mpoService;
        public MPoController(IMPoService mpo)
        {
            mpoService = mpo;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MPo/GetMPo")]
        public IEnumerable<MPo> GetMPo()
        {
            return mpoService.GetMPo();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MPo/GetMPoById")]
        public MPo GetMPoById(string id)
        {
            return mpoService.GetMPoById(id);
        }

    }
}