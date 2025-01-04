using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Users", Schema = "MinervaTestBase")]
    public class User
    {
        public User() { }

        public User(string Username, string Password, string FullName, string Email) 
        {
            Random random = new Random();
            Id = random.Next();
            this.Username = Username;
            this.PasswordHash = Hashing(Password);
            this.FullName = FullName;
            this.Email = Email;
        }

        string Hashing(string Password)
        { return Password; }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

}
