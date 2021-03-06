using API.error;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("errors/{code}")]
      [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : BaseApiController
    {


        public IActionResult Error(int code)
        {

            return new ObjectResult(new ApiResponse(404));
        }

    }
}