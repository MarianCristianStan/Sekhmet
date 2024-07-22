using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Like
    {
        [Key]
        public int Like_ID { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Post")]
        public int Post_ID { get; set; }
        public Post? Post { get; set; }
    }
}
