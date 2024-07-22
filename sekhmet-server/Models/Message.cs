using sekhmet_server.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sekhmet_server.Models
{
    public class Message
    {
        [Key]
        public int Message_ID { get; set; }
        public string? Content { get; set; }
        public int User_ID_Sender { get; set; }
        public int User_ID_Receiver { get; set; }

        [ForeignKey("Conversation")]
        public int Conversation_ID { get; set; }
        public Conversation? Conversation { get; set; }
 
    }
}
