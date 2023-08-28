using Online_Educator_Backend.Model;

namespace Online_Educator_Backend.Data.Repositorys
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
    }
}
