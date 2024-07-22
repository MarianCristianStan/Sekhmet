using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sekhmet_server.Models
{
    public class Post_Media
    {
        [Key]
        public int Post_Media_ID { get; set; }
        public byte[]? Media_File {  get; set; }

        [ForeignKey("Post")]
        public int Post_ID  { get; set; }
        public Post? Post  { get; set; }

    }
}
