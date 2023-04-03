namespace OdontoProject.API.Entity
{
    public class Procedure
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Procedure(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
