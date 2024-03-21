using System.Threading.Channels;

namespace _2._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split();
                string studentFirstName = inputParams[0];
                string studentLastName = inputParams[1];
                int studentAge = int.Parse(inputParams[2]);
                string studentHomeTown = inputParams[3];

                Student student = new Student()
                {
                    FirstName = studentFirstName,
                    LastName = studentLastName,
                    Age = studentAge,
                    HomeTown = studentHomeTown

                };
                studentlist.Add(student);

                input = Console.ReadLine();
            }

            string currentCity = Console.ReadLine();

            List<Student> filteredStudentList = studentlist
                .Where(st => st.HomeTown == currentCity)
                .ToList();

            foreach (Student student in filteredStudentList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
