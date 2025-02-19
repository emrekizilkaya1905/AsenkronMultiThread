using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult>GetContent()
        {
            var myText = new HttpClient().GetStringAsync("https://www.google.com");
            var data = await myText;
            return Ok(data);
        }
    }
}
