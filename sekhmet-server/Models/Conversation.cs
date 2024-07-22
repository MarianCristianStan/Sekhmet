using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Conversation
    {
        [Key]
        public int Conversation_ID { get; set; }
        public string? Conversation_Name { get; set; }
        public int? Conversation_Type { get; set; }

        public ICollection<Message>? Messages { get; set; }
        public ICollection<Conversation_User>? Conversation_Users { get; set; }
    }
}