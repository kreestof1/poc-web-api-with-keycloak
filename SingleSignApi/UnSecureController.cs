using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SingleSignApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UnSecureController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUnSecureData()
        {
            return Ok(new { message = "This is an unprotected resource" });
        }
    }
}