using System.Runtime.CompilerServices;

namespace extension_methods
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string message = "burak";
            Console.WriteLine(message.ReverseText());
            var numbers = new List<int> { 1,2,3, 4, 5 };
            numbers.PrintAll();

        }
        public static string ReverseText(this string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void PrintAll<T>(this List<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

      
    
}
