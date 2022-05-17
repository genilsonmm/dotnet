namespace School.Data.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }

        public Student(string name)
        {
            this.Name = name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
