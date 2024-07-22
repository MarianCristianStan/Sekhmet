using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}