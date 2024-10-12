
using Microsoft.AspNetCore.Mvc;
using simple_crud.IO.User;

namespace simple_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        [HttpGet]
        public ActionResult<Output> GetUser([FromQuery(Name = "Id")] int id)
        {
            var result = new Output()
            {
                Age = 35,
                Email = "email@test.com",
                Group = "developers",
                Id = 2345678,
                Name = "Gabriel Santos",
            };

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Input> CreateUser([FromBody] Input payload)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (payload is null)
            {
                return BadRequest();
            }

            return Ok(payload);
        }
    }
}
