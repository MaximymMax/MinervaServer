using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Vacancy")]
    public class Vacancy
    {
        public Vacancy() { }

        [Key]
        public long id { get; set; }
        public string title { get; set; }
        public string file { get; set; }
        public long hire_manager_id { get; set; }
        public DateTime publish_date { get; set; }
        public DateTime remove_date { get; set; }
        public long views { get; set; }

        [ForeignKey(nameof(hire_manager_id))]
        public Account Account { get; set; } = null!;
    }

}
