using Domain.Enums;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User()
        {

        }
        public User(string name, string email, int enrollNumber, string password, string phone, bool isFump)
        {
            Name = name;
            Email = email;
            EnrollNumber = enrollNumber;
            Password = password;
            Phone = phone;
            IsFump = isFump;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public int EnrollNumber { get; set; }
        public string CardId { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsFump { get; set; }
        public Fump? Fump { get; set; }

        public void Update(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
