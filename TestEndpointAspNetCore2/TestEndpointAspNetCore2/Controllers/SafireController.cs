using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestEndpointAspNetCore2.Controllers
{
    public class SafireController: Controller
    {
        [HttpPost ( "api/testsafire" )]
        public void PostSafire ( )
        {
            var stream = new StreamReader ( Request.Body );
            var body = stream.ReadToEnd();
            Console.WriteLine ( body );
        }
    }
}
