using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class CommRepository : RepositoryBase<Comm>, ICommRepository
    {
        public CommRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}