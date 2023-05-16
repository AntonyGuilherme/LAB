using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        public void Save(User user);
    }
}
