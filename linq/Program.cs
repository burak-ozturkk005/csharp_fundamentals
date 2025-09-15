using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            int[] numbers = { 3, 5, 7, 9, 4, 2, 6 };
            var result = from num in numbers
                         where num > 4
                         orderby num descending
                         select num;
            foreach(var num in result)
            {
                Console.WriteLine(num);
            }

            var res = numbers.Where(num => num > 4).OrderByDescending(num => num);
            foreach ( var num in res)
            {
                Console.WriteLine(num);
            }
            var filtered = numbers.Where(n => n > 5); // Belirli bir koşulu sağlayan öğeleri seçmek için kullanılır.
            var sortedAsc = numbers.OrderBy(n => n); //sıralama işlemi
            var sortedDesc = numbers.OrderByDescending(n => n); //Sıralama işlemleri için kullanılır
            var squaredNumbers = numbers.Select(n => n * n); //Koleksiyonda belirli alanları veya verileri seçmek 
            //için kullanılır.
            List<people> peopleList = SeedData.GetPeople();
            var allPeople = from p in peopleList
                            select p;
            foreach (var person in allPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age} yaşında notu : {person.Grade}");
            }
            var olderThan30 = from p in peopleList
                              where p.Age > 30
                              select p;
            foreach(var person in olderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age} yaşında.");
            }
           
        }
        public static class SeedData
        {
            public static List<people> GetPeople()
            {
                return new List<people>
                {
                    new people {Name = "Burak", Age = 28, Grade = 89},
                    new people {Name = "Ahmet", Age = 25, Grade = 56},
                    new people {Name = "Yavuz", Age = 32, Grade = 78}
                };

            }
        }
    }
}

