
namespace AppDemo
{
    public class Aluno
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Aluno(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
