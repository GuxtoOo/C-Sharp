using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : Controller
    {
        public BaseController() { }
    }
}
