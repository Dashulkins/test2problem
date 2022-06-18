using Microsoft.AspNetCore.Mvc;
using tests22297.Services;

namespace tests22297.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IDbService service;

        public HomeController(IDbService _service) {
            service = _service;
        }

        [HttpGet("{idAction}")]
        public IActionResult getAction(int idAction) {
            if (service.getAction(idAction) == null)
            {
                return BadRequest("Such action doesn't exist");
            }
            else {
                return Ok(service.getAction(idAction));
            }
        }

        [HttpDelete("{idAction}")]
        public ActionResult deleteAction(int idAction) {
            if (service.deleteAction(idAction) == -1) {
                return BadRequest("Such action doesn't exist");
            }
            if (service.deleteAction(idAction) == -2)
            {
                return BadRequest("Action is not in proccess");
            }
            else{ 
                return Ok ("Actioon " + idAction + " was successfully deleted");
            }
        }
    }
}
