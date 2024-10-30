using System.Threading.Channels;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            List<Person> people = new List<Person>
            {
                new Person {Name = "Jesse", Surname = "Pinkman", Age = 21},
                new Person {Name = "Walter", Surname = "White", Age = 50},
                new Person {Name = "Mike", Surname = "Ermanthrautov", Age = 18},
                new Person {Name = "Flynn", Surname = "Whiteov", Age = 16}
            };
            Console.WriteLine("Guy whose name is Jesse : ");
            Console.WriteLine($"{people.Find(x=>x.Name == "Jesse").Name} {people.Find(x=>x.Name == "Jesse").Surname}");

            Console.WriteLine("\nThe people older than 20 :");
            people.FindAll(p => p.Age > 20)
                .ForEach(s => Console.WriteLine($"{s.Name} {s.Surname} "));

            Console.WriteLine("\nThe people whose surname ends with \"ov\" or \"ova\" : ");
            people.FindAll(p => p.Surname.EndsWith("ov"))
                .ForEach(s => Console.WriteLine($"{s.Name} {s.Surname}"));

            List<Exam> exams = new List<Exam>
            {
                new Exam {Subject = "Math", Duration = 3, StartDate = new DateTime(int.Parse("2024"), int.Parse("10"), int.Parse("30"), int.Parse("12"), int.Parse("00"), int.Parse("34"))},
                new Exam {Subject = "Physics", Duration = 2, StartDate = new DateTime(int.Parse("2024"), int.Parse("10"), int.Parse("24"), int.Parse("10"), int.Parse("15"), int.Parse("47"))},
                new Exam {Subject = "English", Duration = 1, StartDate = new DateTime(int.Parse("2024"), int.Parse("11"), int.Parse("10"), int.Parse("08"), int.Parse("30"), int.Parse("08"))},
                new Exam {Subject = "Biology", Duration = 3, StartDate = new DateTime(int.Parse("2024"), int.Parse("11"), int.Parse("14"), int.Parse("11"), int.Parse("45"), int.Parse("19"))},
            };
            Console.WriteLine("\nThe exams in last 7 days : ");
            exams.FindAll(e => e.StartDate.Day > dateTime.Day - int.Parse("07"))
                .ForEach(e => Console.WriteLine($"Subject : {e.Subject} \nDuration : {e.Duration} hours."));

            Console.WriteLine("\nExams lasting longer than 2 hours :");
            exams.FindAll(e => e.Duration > 2)
                .ForEach(e => Console.WriteLine($"Subject : {e.Subject} \nDuration : {e.Duration} hours."));

            Console.WriteLine("\nExams that are being held right now : ");
            exams.FindAll(e => e.EndDate.Second > dateTime.Second && e.StartDate.Second < dateTime.Second)
                .ForEach(e => Console.WriteLine($"Subject : {e.Subject} \nDuration : {e.Duration} hours."));
        }
    }
}
