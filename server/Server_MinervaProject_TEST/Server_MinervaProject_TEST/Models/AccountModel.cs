using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Accounts")]
    public class Account
    {
        public Account() { }

        public Account(string Username, string Password, string Email, string? phone, Account_types AccountType)
        {
            Random random = new Random();
            id = random.Next();
            user_name = Username;
            hashed_password = Hashing(Password);
            email = Email;
            this.phone = phone;

            Person = new Person(this);
            Achievements = new Achievements(this);
            Account_type = AccountType;
        }

        string Hashing(string Password)
        { return Password; }

        public long id { get; set; }
        public string user_name { get; set; }
        public long type_id { get; set; }
        public string email { get; set; }
        public string? phone { get; set; }
        public string? resume { get; set; }
        public string hashed_password { get; set; }
        public string? profile_proto { get; set; }

        public Person Person { get; set; } = null!;
        public Achievements Achievements { get; set; } = null!;

        [ForeignKey(nameof(type_id))]
        public Account_types Account_type { get; set; } = null!;
    }

    [Table("Account_types")]
    public class Account_types
    {
        public Account_types() { }

        [Key]
        public long id { get; set; }
        public string type_name { get; set; }
    }
}
