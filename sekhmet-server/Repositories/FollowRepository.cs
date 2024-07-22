using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class FollowRepository : RepositoryBase<Follow>, IFollowRepository
    {
        public FollowRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}