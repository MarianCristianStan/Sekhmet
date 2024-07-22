using sekhmet_server.Models;
using sekhmet_server.Repositories.Interfaces;

namespace sekhmet_server.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private SekhmetContext _sekhmetContext;
        private IUserRepository? _userRepository;
        private ICommRepository? _commRepository;
        private IConversationRepository? _conversationRepository;
        private IConversation_UserRepository? _conversationUserRepository;
        private IFollowRepository? _followRepository;
        private IPostRepository? _postRepository;
        private ILikeRepository? _likeRepository;
        private IPost_MediaRepository? _postMediaRepository;
        private IMessageRepository? _messageRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_sekhmetContext);
                }

                return _userRepository;
            }
        }
        public ICommRepository CommRepository
        {
            get
            {
                if (_commRepository == null)
                {
                    _commRepository = new CommRepository(_sekhmetContext);
                }

                return _commRepository;
            }
        }
        public IConversationRepository ConversationRepository
        {
            get
            {
                if (_conversationRepository == null)
                {
                    _conversationRepository = new ConversationRepository(_sekhmetContext);
                }

                return _conversationRepository;
            }
        }
        public IConversation_UserRepository ConversationUserRepository
        {
            get
            {
                if (_conversationUserRepository == null)
                {
                    _conversationUserRepository = new Conversation_UserRepository(_sekhmetContext);
                }
                return _conversationUserRepository;
            }
        }

        public IFollowRepository FollowRepository
        {
            get
            {
                if (_followRepository == null)
                {
                    _followRepository = new FollowRepository(_sekhmetContext);
                }
                return _followRepository;
            }
        }

        public IPostRepository PostRepository
        {
            get
            {
                if (_postRepository == null)
                {
                    _postRepository = new PostRepository(_sekhmetContext);
                }
                return _postRepository;
            }
        }

        public ILikeRepository LikeRepository
        {
            get
            {
                if (_likeRepository == null)
                {
                    _likeRepository = new LikeRepository(_sekhmetContext);
                }
                return _likeRepository;
            }
        }

        public IPost_MediaRepository PostMediaRepository
        {
            get
            {
                if (_postMediaRepository == null)
                {
                    _postMediaRepository = new Post_MediaRepository(_sekhmetContext);
                }
                return _postMediaRepository;
            }
        }

        public IMessageRepository MessageRepository
        {
            get
            {
                if (_messageRepository == null)
                {
                    _messageRepository = new MessageRepository(_sekhmetContext);
                }
                return _messageRepository;
            }
        }
        public RepositoryWrapper(SekhmetContext sekhmetContext)
        {
            _sekhmetContext = sekhmetContext;
        }

        public void Save()
        {
            _sekhmetContext.SaveChanges();
        }
    }
}