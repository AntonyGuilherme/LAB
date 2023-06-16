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

        public UserModel? SingIn(string email, string password) 
        {
            var user = UserRepository.GetBy(email, password);

            if (user == null)
                return null;

            return new UserModel(user);
        }

        public void ToggleCardUsability(long userId)
        {
            var user = UserRepository.GetById(userId);

            user?.ToggleCardUsability();
        }

        public void InsertPaymentToken(long userId, string paymentToken)
        {
            var user = UserRepository.GetById(userId);

            user?.InsertPaymentToken(paymentToken);
        }

        public bool CanUserAccessCollegeRestaurant(string cardId)
        {
            var user = UserRepository.GetByCardId(cardId);

            return user != null && AccessVerifier.CanUserAccessCollegeRestaurant(user);
        }
    }

    public class UserModel 
    {
        public long Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Fump { get; }
        public string EnrollNumber { get; }
        public string CardId { get; }
        public bool IsActive { get; }
        public string PaymentToken { get; }

        public UserModel(User user) 
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            CardId = user.CardId;
            Fump = user.Fump;
            IsActive = user.IsActive;
            EnrollNumber = user.EnrollNumber;
            PaymentToken = user.PaymentToken;
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
            if (user.Id == 0)
                user.Id = _users.Count + 1;

            _users.Add(user);
        }

        public User? GetBy(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User? GetById(long userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public User? GetByCardId(string cardId)
        {
           return _users.FirstOrDefault(u => u.CardId == cardId);
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
            IsActive = true;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fump { get; set; }
        public string EnrollNumber { get; set; }
        public string CardId { get; set; }
        public bool IsActive { get; set; }
        public string PaymentToken { get; set; }
        public bool HasPaymentToken => PaymentToken != null;

        public void InsertUFMGData(UFMGUserData ufmgUserData)
        {
            Fump = ufmgUserData.Fump;
            CardId = ufmgUserData.CardId;
        }

        public void ToggleCardUsability()
        {
            IsActive =  !IsActive;
        }

        public void InsertPaymentToken(string paymentToken)
        {
            PaymentToken = paymentToken;
        }
    }

    public class AccessVerifier
    {
        public static bool CanUserAccessCollegeRestaurant(User user)
        {
            return user.HasPaymentToken && user.IsActive;
        }
    }
}
