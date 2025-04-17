using Microsoft.AspNetCore.Mvc;
using FreelancerDirectory.Models;
using FreelancerDirectory.Data;

namespace FreelancerDirectory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerDirectoryController : ControllerBase
    {
        private readonly ApiContext _context;

        public FreelancerDirectoryController(ApiContext context)
        {
            _context = context;
        }

        // Create or Update a user
        [HttpPost]
        public IActionResult CreateEdit(User user)
        {
            if (user.Id == 0)
            {
                _context.Users.Add(user);
            }
            else
            {
                var UserInDb = _context.Users.Find(user.Id);
                if (UserInDb == null)
                    return NotFound();

                // Update properties manually
                UserInDb.UserName = user.UserName;
                UserInDb.Mail = user.Mail;
                UserInDb.PhoneNumber = user.PhoneNumber;
                UserInDb.Skillsets = user.Skillsets;
                UserInDb.Hobby = user.Hobby;
            }

            _context.SaveChanges();
            return Ok(user);
        }

        // Get user by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.Users.Find(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // Get all users
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var result = _context.Users.ToList();
            return Ok(result);
        }

        // Delete user by ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Users.Find(id);
            if (result == null)
                return NotFound();

            _context.Users.Remove(result);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
