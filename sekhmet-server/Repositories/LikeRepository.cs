using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class LikeRepository : RepositoryBase<Like>, ILikeRepository
    {
        public LikeRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}