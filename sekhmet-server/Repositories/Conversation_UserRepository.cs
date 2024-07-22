using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class Conversation_UserRepository : RepositoryBase<Conversation_User>, IConversation_UserRepository
    {
        public Conversation_UserRepository(SekhmetContext sekhmetContext)
           : base(sekhmetContext)
        {
        }
    }
}