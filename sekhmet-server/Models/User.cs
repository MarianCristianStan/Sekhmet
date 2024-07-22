using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public string Password_Hash { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public byte[]? Profile_Picture { get; set; }
        public string? Location { get; set; }   

        public ICollection<Follow>? Followings { get; set; }
        public ICollection<Follow>? Followers { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comm>? Comms { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Conversation_User>? Conversation_Users { get; set; }
    }
}
