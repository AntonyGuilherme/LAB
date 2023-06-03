using Applicaition.Dto;

using Domain.Entities;

namespace Applicaition.Interfaces
{
    public interface IUserMapper
    {
        public UserResponse Map(User user);
        public List<UserResponse> Map(IEnumerable<User> users);
    }
}
