using OdontoProject.API.Entity;

namespace OdontoProject.API.Data
{
    public static class Database
    {
        public static List<User> users = new List<User>() {
            new User("Maria da Silva", "123.456.221-09"),
            new User("João da SIlva", "456.123.567-90")
        };

        public static List<Procedure> procedures = new List<Procedure>()
        {
            new Procedure("Limpeza"),
            new Procedure("Obturação")
        };

        public static List<OdontoCare> odontoCare = new List<OdontoCare>();
    }
}
