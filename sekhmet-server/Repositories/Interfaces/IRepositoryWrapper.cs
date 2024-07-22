using sekhmet_server.Models;

namespace sekhmet_server.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
       
        IUserRepository? UserRepository { get; }
        ICommRepository? CommRepository { get; }
        IConversationRepository? ConversationRepository { get; }
        IConversation_UserRepository? ConversationUserRepository { get; }
        IFollowRepository? FollowRepository { get; }
        IPostRepository? PostRepository { get; }
        ILikeRepository? LikeRepository { get; }
        IPost_MediaRepository? PostMediaRepository { get; }
        IMessageRepository? MessageRepository { get; }

        void Save();
    }
}
