using Microsoft.AspNetCore.Mvc;
using morleys_backend.Models.DbModels;

namespace morleys_backend.Controllers
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Consider using a separate class for secure password handling
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }

    [ApiController]
    [Route("api/signup")]

    public class SignUpController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World!!";
        }


        [HttpPost]
        public ActionResult<string> Post(UserDto userDto)
        {
            User user = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Password = userDto.Password, // Securely hash password
                Address = userDto.Address,
                PhoneNumber = userDto.PhoneNumber,
                Role = userDto.Role,
                CreatedAt = DateTime.UtcNow
            };
            return Ok(user);
        }
    }
}
