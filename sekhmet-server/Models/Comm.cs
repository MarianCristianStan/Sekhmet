using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Comm
    {
        [Key]
        public int Comm_ID { get; set; }
        public string? Content { get; set; }
        public DateTime Created_At_Datetime { get; set; }
   
        [ForeignKey("User")]
        public int Created_By_User_ID { get; set; }
        public User? User { get; set; }

        [ForeignKey("Post")]
        public int Post_ID { get; set; }
        public Post? Post { get; set; }

        public int? Comm_Reply_To_ID { get; set; }
        public Comm? Comm_Replied_To { get; set; }
        public ICollection<Comm>? Replies { get; set; }
    }
}
