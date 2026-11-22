using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using BSIT_32E2_Llorente_Laurence.DTO.User;
using BSIT_32E2_Llorente_Laurence.DTO.UserGroup;

namespace BSIT_32E2_Llorente_Laurence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUsersResponse
            {
                Users = new()
                {
                    new(){Id = 1, Name = "Liam Vance", Email = "liam.vance@example.com"},
                    new(){Id = 2, Name = "Noah Sterling", Email = "noah.sterling@example.com"},
                    new(){Id = 3, Name = "Mia Alvarez", Email = "mia.alvarez@example.com"},
                    new(){Id = 4, Name = "Aria Mendoza", Email = "aria.mendoza@example.com"},
                    new(){Id = 5, Name = "Zoe Castillo", Email = "zoe.castillo@example.com"},
                    new(){Id = 6, Name = "Ethan Reyes", Email = "ethan.reyes@example.com"},
                    new(){Id = 7, Name = "Chloe Santos", Email = "chloe.santos@example.com"},
                    new(){Id = 8, Name = "Nadia Cruz", Email = "nadia.cruz@example.com"},
                    new(){Id = 9, Name = "Kenji Ramos", Email = "kenji.ramos@example.com"},
                    new(){Id = 10, Name = "Tessa Navarro", Email = "tessa.navarro@example.com"},
                }
            };
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id)
        {
            return Ok(new GetUserByIDResponse
            {
                User = new GetUserDTO
                {
                    Id = id,
                    Name = "John Doe",
                    Email = "john.doe@example.com"
                },
                UserGroups = new()
                {
                    new(){UserId = id, GroupId = 1},
                    new(){UserId = id, GroupId = 2},
                }
            });
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUsersResponse request)
        {
            return Ok(new CreateUsersResponse
            {
                Id = 11,
                Name = request.Name,
                Email = request.Email
            });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id, [FromBody] EditUsersResponse request)
        {
            return Ok(new EditUsersResponse
            {
                Id = id,
                Name = request.Name,
                Email = request.Email
            });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}