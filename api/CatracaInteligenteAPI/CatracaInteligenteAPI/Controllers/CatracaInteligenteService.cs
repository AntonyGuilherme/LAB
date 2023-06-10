namespace CatracaInteligenteAPI.Controllers
{
    public class CatracaInteligenteService
    {
        public UserRepository UserRepository { get; }
        public UFMGRepository UFMGRepository { get; }

        public CatracaInteligenteService()
        {
            UserRepository = new UserRepository();
            UFMGRepository = new UFMGRepository();
        }

        public void SingUp(string name, string email, string enrollNumber, string password)
        {
            var user = new User(name, email, enrollNumber, password);
            
            var ufmgUserData = UFMGRepository.GetUserData(enrollNumber);
            user.InsertUFMGData(ufmgUserData);

            UserRepository.Save(user);
        }

    }

    public class UFMGUserData 
    {
        public string CardId { get; set; }
        public string Fump { get; set; }
    }

    public class UFMGRepository
    {
        public UFMGUserData GetUserData(string enrollNumber)
        {
            return new UFMGUserData { CardId = "", Fump = "" };
        }
    }

    public class UserRepository 
    {
        public static List<User> _users = new List<User>();
        public void Save(User user) 
        {
            _users.Add(user);
        }
    }

    public class User 
    {
        public User(string name, string email, string enrollNumber, string password)
        {
            Name = name;
            Email = email;
            EnrollNumber = enrollNumber;
            Password = password;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fump { get; set; }
        public string EnrollNumber { get; set; }
        public string CardId { get; set; }
        public bool IsActive { get; set; }

        public void InsertUFMGData(UFMGUserData ufmgUserData)
        {
            Fump = ufmgUserData.Fump;
            CardId = ufmgUserData.CardId;
        }
    }
}
