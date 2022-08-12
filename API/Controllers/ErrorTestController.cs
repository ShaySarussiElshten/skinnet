using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   
   [ApiController]
    [Route("api/[controller]")]
    public class ErrorTestController : ControllerBase
    {
         private readonly StoreContext _context;
        public ErrorTestController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound(new ApiResponse(404));
        }

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }

        [HttpGet("unauthorised")]
        public ActionResult GetUnauthorised()
        {
            return Unauthorized(new ApiResponse(401));
        }

        // [HttpGet("validation-error")]
        // public ActionResult GetValidationError()
        // {
        //     ModelState.AddModelError("Problem1", "This is the first error");
        //     ModelState.AddModelError("Problem2", "This is the second error");
        //     return ValidationProblem();
        // }

        // [HttpGet("servererror")]
        // public ActionResult GetServerError()
        // {
        //     var thing = _context.Products.Find(42);

        //     var thingToReturn = thing.ToString();

        //     return Ok();
        // }

        
    }
}