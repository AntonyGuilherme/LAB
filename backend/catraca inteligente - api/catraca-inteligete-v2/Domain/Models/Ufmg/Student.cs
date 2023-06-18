using Domain.Enums;

namespace Domain.Models.Ufmg
{
    public class Student
    {
        public string CardId { get; set; }
        public int EnrollNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsFump { get; set; }
        public Fump? Fump { get; set; }

    }
}
