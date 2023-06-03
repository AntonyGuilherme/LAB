using Applicaition.Dto;

namespace Applicaition.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<UserResponse> GetAll();
        public UserResponse GetUser(int id);
        public UserResponse SingUp(UserSingUpRequest singUpRequest);
        public UserResponse UpdateUser(int id, UserUpdateRequest userUpdate);
        public bool DeleteUser(int id);
    }
}
