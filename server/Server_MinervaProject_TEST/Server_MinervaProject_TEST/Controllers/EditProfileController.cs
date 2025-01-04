using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Server_MinervaProject_TEST.Data;
using Server_MinervaProject_TEST.Models;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Server_MinervaProject_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditProfileController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EditProfileController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("SetPhoto")]
        public async Task<IActionResult> SetPhoto(SetPhotoRequest File)
        {
            if (File.Photo == null || File.Photo.Length == 0)
            {
                return BadRequest("Файл не выбран или он пустой.");
            }

            var existingUser = _context.Accounts.SingleOrDefault(u => u.user_name == File.Username);

            if (existingUser == null)
                return Conflict("Такого пользователя не найдено");

            var uniqueFileName = Guid.NewGuid().ToString() + "_" + File.Photo.FileName;
            var filePath = Path.Combine(@"C:\диск D\Visual Studio\Files", uniqueFileName);

            existingUser.profile_proto = filePath;
            _context.SaveChanges();

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await File.Photo.CopyToAsync(fileStream);
            }

            return Ok("Фото успешно загружено.");
        }
    }

    public class SetPhotoRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public IFormFile Photo { get; set; }
    }

}
