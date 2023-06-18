using Domain.Enums;

namespace Applicaition.Mappers
{
    public class UserSingInResponse
    {
        public long Id { get; set; } 
        public string CardId { get; set; }
        public string Name { get; set; }
        public int EnrollNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsFump { get; set; }
        public Fump? Fump { get; set; }
        public bool IsActive { get; set; }
        public string CreditCard { get; set; }
    }
}