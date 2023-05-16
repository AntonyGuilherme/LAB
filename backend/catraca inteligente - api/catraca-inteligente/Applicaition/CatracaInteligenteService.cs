using Applicaition.Dto;

using Domain.Entities;

namespace Applicaition
{
    public class CatracaInteligenteService
    {

        private readonly IUserRepository _userRepository;

        public CatracaInteligenteService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void SingUp(UserDTO userDTO)
        {
            var user = new User(userDTO.Name, userDTO.Email, userDTO.EnrollNumber, userDTO.CardId, userDTO.Password, userDTO.Phone);
            _userRepository.Save(user);
        }

    }

    public interface IUserRepository
    {
        public void Save(User user);
    }



}
