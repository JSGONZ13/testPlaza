using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Api.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("Home")]
        public string Index(string test_)
        {
            string test = test_;
            return test;
        }
    }
}
