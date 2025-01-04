using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Server_MinervaProject_TEST.Data;
using Server_MinervaProject_TEST.Models;
using System.ComponentModel.DataAnnotations;

namespace Server_MinervaProject_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegistController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Registration([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingUser = _context.Accounts.SingleOrDefault(u => u.user_name == request.Username || u.email == request.Email);

            if (existingUser!=null && existingUser.user_name == request.Username)
                return Conflict("Username is already taken");
            else if(existingUser != null && existingUser.email == request.Email)
                return Conflict("Email is already taken");
            else
            {
                Account newAccount = new Models.Account(request.Username, request.Password, request.Email, null, _context.Account_types.SingleOrDefault(u => u.id == 0));
                _context.Accounts.Add(newAccount);
                _context.SaveChanges();
                return Ok("Successful registration");
            }
        }
    }

    public class RegisterRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
