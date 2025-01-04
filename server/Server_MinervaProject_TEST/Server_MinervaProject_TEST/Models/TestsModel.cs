using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Tests")]
    public class Tests
    {
        public Tests() { }

        [Key]
        public long id { get; set; }
        public string title { get; set; }
        public long rating { get; set; }
        public long author_id { get; set; }
        public string file { get; set; }

        [ForeignKey(nameof(author_id))]
        public Account Account { get; set; } = null!;
    }
}
