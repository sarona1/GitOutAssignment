using Microsoft.AspNetCore.Mvc;

namespace GitOutAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var myData = new 
            { 
                FirstName = "Saron", 
                LastName = "Abraham" 
            };
            
            return Ok(myData);
        }
    }
}