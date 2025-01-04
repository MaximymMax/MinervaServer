using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_MinervaProject_TEST.Models
{
    [Table("Articles")]
    public class Articles
    {
        public Articles() { }

        [Key]
        public long id { get; set; }
        public string title { get; set; }
        public long rating { get; set; }
        public long author_id { get; set; }
        public string first_paragraph { get; set; }
        public string file { get; set; }
        public long theme_id { get; set; }

        [ForeignKey(nameof(author_id))]
        public Account Account { get; set; } = null!;

        [ForeignKey(nameof(theme_id))]
        public Articles_theme Articles_theme { get; set; } = null!;
    }

    [Table("Articles_theme")]
    public class Articles_theme
    {
        public Articles_theme() { }

        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }
}
