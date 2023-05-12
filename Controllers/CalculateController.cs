using Api.Entities;
using Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly DatabaseContext context;

        public CalculateController(DatabaseContext context)
        {
            this.context = context;
        }

        [Route("Add")]
        [HttpPost]
        public int Add(AddModel model)
        {
            var result = model.Number1 + model.Number2;

            var add = new Add
            {
                Number1 = model.Number1,
                Number2 = model.Number2,
                Result = result
            };

            context.Adds.Add(add);
            context.SaveChanges();

            return result;
        }
    }
}
