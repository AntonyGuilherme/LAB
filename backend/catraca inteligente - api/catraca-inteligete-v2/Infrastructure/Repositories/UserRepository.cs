using Domain.Entities;
using Domain.Models.Ufmg;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        private readonly List<User> _users;
        private readonly List<Student> _students;
        public UserRepository(List<User> users, List<Student> students)
            : base()
        {
            _users = users;
            _students = students;
        }

        public override IEnumerable<User> GetAll()
        {
            return _users;
        }

        public override User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public override User Add(User user)
        {
            var ufmgStudentInfo = _students.FirstOrDefault(x => x.EnrollNumber == user.EnrollNumber);
            user.SetUfmgData(ufmgStudentInfo);
            _users.Add(user);
            return user;
        }

        public bool TryPayment(string cardId)
        {
            return _users.FirstOrDefault(x => x.CardId == cardId).CreditCard != null;
        }
    }
}
