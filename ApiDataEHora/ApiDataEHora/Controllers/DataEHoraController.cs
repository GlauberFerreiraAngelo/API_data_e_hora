using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDataEHora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataEHoraController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            string data = DateTime.Now.ToString();
            return BadRequest(data);
        }

    }
}
