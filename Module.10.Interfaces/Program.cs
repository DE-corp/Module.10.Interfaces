using System;

namespace Module._10.Interfaces
{
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {

    }

    public class Account : User
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);
        }
    }
}
