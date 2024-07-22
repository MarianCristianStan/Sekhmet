using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class Post_MediaRepository : RepositoryBase<Post_Media>, IPost_MediaRepository
    {
        public Post_MediaRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}