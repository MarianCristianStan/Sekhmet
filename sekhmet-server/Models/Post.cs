using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Post
    {
        [Key]
        public int Post_ID  { get; set; }
        public string? Description { get; set; }
        public DateTime? Created_At_Datetime { get; set; }  

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User? User { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comm>? Comms { get; set; }
        public ICollection<Post_Media>? Post_Medias { get; set; }
    }
}
