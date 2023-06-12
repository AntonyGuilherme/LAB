using Applicaition.Dto;
using Applicaition.Interfaces;

using Domain.Entities;

namespace Applicaition.Mappers
{
    public class UserMapper : IUserMapper
    {
        public UserResponse Map(User user)
            => new UserResponse
            {
                CardId = user.CardId,
                Name = user.Name,
                EnrollNumber = user.EnrollNumber,
                Email = user.Email,
                Phone = user.Phone
            };

        public List<UserResponse> Map(IEnumerable<User> users)
        {
            var usersResponse = new List<UserResponse>();
            foreach (var user in users)
            {
                usersResponse.Add(new UserResponse
                {
                    CardId = user.CardId,
                    Name = user.Name,
                    EnrollNumber = user.EnrollNumber,
                    Email = user.Email,
                    Phone = user.Phone
                });
            }

            return usersResponse;
        }

        public UserSingInResponse MapSingIn(User user)
         => user == null ? null : new UserSingInResponse
         {
             CardId = user.CardId,
             Name = user.Name,
             EnrollNumber = user.EnrollNumber,
             Email = user.Email,
             Phone = user.Phone,
             IsFump = user.IsFump,
             Fump = user.Fump,
             IsActive = user.IsActive,
         };
    }
}
