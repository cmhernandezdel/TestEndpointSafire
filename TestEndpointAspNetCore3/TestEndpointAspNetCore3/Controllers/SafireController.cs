using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestEndpointAspNetCore3.Controllers
{

    [ApiController]
    public class SafireController : ControllerBase
    {

        [HttpPost ( "api/testsafire" )]
        public async Task PostSafire ()
        {
            var stream = new StreamReader ( Request.Body );
            var body = await stream.ReadToEndAsync();
            Console.WriteLine ( body );
        }
    }
}