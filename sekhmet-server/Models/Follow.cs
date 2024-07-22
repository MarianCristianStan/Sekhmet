namespace sekhmet_server.Models
{
    public class Follow
    {
        public int FollowingUserId { get; set; }
        public User? FollowingUser { get; set; } 

        public int FollowedUserId { get; set; }
        public User? FollowedUser { get; set; }
    }
}
