using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
      // gf PhotoManagementChallenge
      // IUserRepository UserRepository {get; }
      // IMessageRepository MessageRepository {get;}
      // ILikesRepository LikesRepository {get; }
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikesRepository LikesRepository { get; }
        IPhotoRepository PhotoRepository { get; }      
      Task<bool> Complete();
      bool HasChanges();
    }
}