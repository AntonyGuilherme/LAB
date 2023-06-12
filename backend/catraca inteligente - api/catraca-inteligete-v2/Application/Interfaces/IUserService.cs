using Applicaition.Dto;
using Applicaition.Mappers;

namespace Applicaition.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<UserResponse> GetAll();
        public UserResponse GetUser(int id);
        public UserSingInResponse SingIn(UserSingInRequest singInRequest);
        public UserResponse SingUp(UserSingUpRequest singUpRequest);
        public UserResponse UpdateUser(int id, UserUpdateRequest userUpdate);
        public bool DeleteUser(int id);
    }
}
