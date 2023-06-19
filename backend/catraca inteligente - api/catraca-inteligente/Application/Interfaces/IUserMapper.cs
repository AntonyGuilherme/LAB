using Applicaition.Dto;
using Applicaition.Mappers;

using Domain.Entities;

namespace Applicaition.Interfaces
{
    public interface IUserMapper
    {
        public UserResponse Map(User user);
        public UserSingInResponse MapSingIn(User user);
        public List<UserResponse> Map(IEnumerable<User> users);
    }
}
