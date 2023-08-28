using Online_Educator_Backend.Model;
using System;

namespace Online_Educator_Backend.Data.Repositorys
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() 
        {
            using (var context = new UserContext())
            {
                var authors = new List<User>
                {
                new User
                {
                     Name = "user",
                    Email = "TTT@gmail.com",
                    Password = "password",
                    Id = 1,
                }
                };
                context.Users.AddRange(authors);
                context.SaveChanges();
            }

        }

        public List<User> GetUsers()
        {
            using (var context = new UserContext())
            {
                var list = context.Users.ToList();
                return list;
            }
        }
    }
}
