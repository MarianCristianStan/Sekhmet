using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}
