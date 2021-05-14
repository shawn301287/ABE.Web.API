using ABE.Web.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABE.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleDataController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(SampleData.GetSomeSamples());
        }
    }
}
