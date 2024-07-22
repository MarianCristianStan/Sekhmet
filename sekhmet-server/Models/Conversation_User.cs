using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Conversation_User
    {
        [Key]
        public int Conversation_User_ID { get; set; }

        [ForeignKey("Conversation")]
        public int Conversation_ID { get; set; }
        public Conversation? Conversation { get; set; }

        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User? User { get; set; }

    }
}