using Domain.Enums;
using Domain.Models.Ufmg;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User()
        {

        }
        public User(string name, string email, int enrollNumber, string password, string phone)
        {
            Name = name;
            Email = email;
            EnrollNumber = enrollNumber;
            Password = password;
            Phone = phone;
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
        public string CreditCard { get; set; }
        public DateTime LastAccess { get; private set; } = DateTime.Today;

        public void Update(string name, string email, string phone, bool isActive)
        {
            Name = name;
            Email = email;
            Phone = phone;
            IsActive = isActive;
        }

        public void SetUfmgData(Student ufmgStudentInfo)
        {
            IsFump = ufmgStudentInfo.IsFump;
            Fump = ufmgStudentInfo.Fump;
            IsActive = ufmgStudentInfo.IsActive;
            CardId = ufmgStudentInfo.CardId;
        }

        public bool CanAccess()
        {
            var actualDiferenceOfHours = (DateTime.Now - LastAccess).TotalHours;
            
            LastAccess = DateTime.Now;

            return IsActive && actualDiferenceOfHours > 3; 
        }
    }
}
