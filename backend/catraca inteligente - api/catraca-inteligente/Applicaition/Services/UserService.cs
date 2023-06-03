using Applicaition.Dto;
using Applicaition.Interfaces;

using Domain.Entities;
using Domain.Repositories;

namespace Applicaition.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;

        public UserService(IUserRepository userRepository, IUserMapper userMapper)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public bool DeleteUser(int id) => _userRepository.Delete(id);

        public IEnumerable<UserResponse> GetAll()
        {
            var users = _userRepository.GetAll();
            return _userMapper.Map(users);
        }

        public UserResponse GetUser(int id)
        {
            var user = _userRepository.GetById(id);
            return _userMapper.Map(user);
        }

        public UserResponse SingUp(UserSingUpRequest singUpRequest)
        {
            var newUser = new User(singUpRequest.Name, singUpRequest.Email, singUpRequest.EnrollNumber,
                singUpRequest.Password, singUpRequest.Phone, singUpRequest.IsFump);

            var userAdded = _userRepository.Add(newUser);
            return _userMapper.Map(userAdded);

        }

        public UserResponse UpdateUser(int id, UserUpdateRequest userUpdate)
        {
            var userToUpdate = _userRepository.GetById(id);
            userToUpdate.Update(userToUpdate.Name, userToUpdate.Email, userToUpdate.Phone);

            var userUpdated = _userRepository.Update(userToUpdate);
            return _userMapper.Map(userUpdated);
        }
    }
}
