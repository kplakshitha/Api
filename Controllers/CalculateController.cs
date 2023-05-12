using Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [Route("Add")]
        [HttpPost]
        public int Add(AddModel model)
        {
            return model.Number1 + model.Number2;
        }
    }
}
