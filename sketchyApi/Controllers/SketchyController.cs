using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace sketchyApi
{
    [Authorize]
    [Route("api/[controller]")]
    public class SketchyController : Controller
    {
        public IActionResult Get()
        {
            return Ok("har");
        }
    }
}