using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly SmartTurnstileContext _smartTurnstileContext;
        public UserRepository(SmartTurnstileContext smartTurnstileContext)
            : base(smartTurnstileContext)
        {

        }
    }
}
