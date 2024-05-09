using APIExemplo.Model;

namespace APIExemplo.Database
{
    public class Context
    {
        private readonly List<User> users = new List<User>();

        private static Context _instance;

        public static Context Instance()
        {
            if(_instance == null)
            {
                _instance = new Context();
            }
            return _instance;
        }

        public void AddUser(User user) => users.Add(user);

        public List<User> GetAll() => users;
    }
}
