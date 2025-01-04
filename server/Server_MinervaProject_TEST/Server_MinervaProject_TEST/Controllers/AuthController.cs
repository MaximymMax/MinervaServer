using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server_MinervaProject_TEST.Data;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server_MinervaProject_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Account = _context.Accounts
                .Include(a => a.Account_type)
                .Include(a => a.Person)
                .Include(a => a.Achievements)
                .SingleOrDefault(u => u.email == request.Email);

            if (Account == null || !VerifyPassword(request.Password, Account.hashed_password))
            {
                return Unauthorized(new { message = "Invalid credentials" });
            }

            string? photoBase64 = null;

            if (Account.profile_proto != null)
            {
                if (System.IO.File.Exists(Account.profile_proto))
                {
                    // Чтение файла в массив байтов
                    var fileBytes = System.IO.File.ReadAllBytes(Account.profile_proto);

                    photoBase64 = Convert.ToBase64String(fileBytes); // Конвертация фото в Base64
                }
            }

            return Ok(new
            {
                Account.id,
                Account.Account_type.type_name,
                Account.email,
                Account.user_name,
                Account.phone,
                Photo = photoBase64
            });
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            return true;
        }
    }

    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
