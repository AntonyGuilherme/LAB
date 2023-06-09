﻿using Applicaition.Dto;
using Applicaition.Interfaces;
using Applicaition.Mappers;

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

        public UserSingInResponse SingIn(UserSingInRequest singInRequest)
        {
            var user = _userRepository
                .GetAll()
                .FirstOrDefault(x => x.Email == singInRequest.Email
                               && x.Password == singInRequest.Password);
            return _userMapper.MapSingIn(user);
        }

        public UserResponse SingUp(UserSingUpRequest singUpRequest)
        {
            var newUser = new User(singUpRequest.Name, singUpRequest.Email, singUpRequest.EnrollNumber,
                singUpRequest.Password, singUpRequest.Phone);

            var userAdded = _userRepository.Add(newUser);
            return _userMapper.Map(userAdded);

        }

        public UserResponse UpdateUser(int id, UserUpdateRequest userUpdate)
        {
            var userToUpdate = _userRepository.GetById(id);
            userToUpdate.Update(userUpdate.Name, userUpdate.Email, userUpdate.Phone, userUpdate.IsActive);

            return _userMapper.Map(userToUpdate);
        }

        public bool TryCanUserAccess(string cardId)
        {
            var user = _userRepository.GetAll().FirstOrDefault(u => u.CardId == cardId);

            return _userRepository.TryPayment(cardId) && user != null && user.CanAccess();
        }

        public void InserPaymentToken(int id, string toke)
        {
            var user = _userRepository.GetById(id);
            user.CreditCard = toke;
        }
    }
}
