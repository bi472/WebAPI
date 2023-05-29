using Microsoft.AspNetCore.Mvc;
using MyClassLibrary;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Dictionary<string, int>> ProcessText([FromBody] string text)
        {
            MyClass myClass = new MyClass();
            Dictionary<string, int> result = myClass.ProcessTextParallel(text);
            return Ok(result);
        }
    }
}