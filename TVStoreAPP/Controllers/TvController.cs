using Microsoft.AspNetCore.Mvc;
using TVStoreAPP.Repositories;

namespace TVStoreAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TvController: ControllerBase
    {
       
        [HttpPost]
        public ActionResult<Request> SendDetails(string message)
        {
            Request request = new Request();
             var result = request.SendRequest(message);
            return new JsonResult(result);

        }
    }
}
