using School.Data.Model;

namespace School.Data.Data
{
    public class Database
    {
        private static Database instance;

        private static List<Student> students = new List<Student>();

        public static Database Instance()
        {
            if (instance == null)
            {
                instance = new Database();
            }

            return instance;
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
