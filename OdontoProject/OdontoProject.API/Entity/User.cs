namespace OdontoProject.API.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }


        public User(string name, string cpf)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cpf = cpf;
        }
    }
}
