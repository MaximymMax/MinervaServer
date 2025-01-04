using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Achievements")]
    public class Achievements
    {
        public Achievements() { }

        public Achievements(Account account) 
        {
            this.Account = account;
        }

        [Key]
        public long account_id { get; set; }
        public long total_tests_count { get; set; }
        public long total_exercises_count { get; set; }
        public long total_articles_count { get; set; }

        [ForeignKey(nameof(account_id))]
        public Account Account { get; set; } = null!;
    }
}
