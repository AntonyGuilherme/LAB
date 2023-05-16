namespace Domain.Entities
{
    public class User
    {
        public User(string name, string email, int enrollNumber, string cardId, string password, int phone)
        {
            Name = name;
            Email = email;
            EnrollNumber = enrollNumber;
            CardId = cardId;
            Password = password;
            Phone = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int EnrollNumber { get; set; }
        public string CardId { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsFump { get; set; }
        public Fump Fump { get; set; }
    }
}
