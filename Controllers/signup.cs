using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using morleys_backend.Data;
using morleys_backend.Models.DbModels;
using morleys_backend.Models.Dto;

namespace morleys_backend.Controllers
{

    [ApiController]
    [Route("api/signup")]

    public class SignUpController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public SignUpController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World!!";
        }


        [HttpPost]
        public ActionResult<string> Post(AddUserDto userDto)
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
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}
