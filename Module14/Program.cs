using System.Threading.Channels;

namespace Module14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectStudents = students.SelectMany(
                s => s.Languages, (s, l) => new { Student = s, Lang = l });

            foreach (var s in selectStudents)
            {
                Console.WriteLine($"Имя студента: {s.Student.Name}");
                Console.WriteLine($"Язык студента: {s.Lang}\n");
            }

        }                
    }
}