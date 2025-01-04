using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Person")]
    public class Person
    {
        public Person() { }

        public Person(Account Account) 
        {
            this.Account = Account;
            dob = DateTime.Now;
        }

        [Key]
        [Column("account_id")]
        public long AccountId { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? father_name { get; set; }
        public DateTime dob { get; set; }

        public Account Account { get; set; } = null!;
    }
}
