using System.IO;
using System.Threading.Tasks; //tüm dosya işlemleri için System.IO namespace kullanılır.
namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //A Doya okuma yöntemleri
            //senkron
            string word = File.ReadAllText("dosya.txt");
            //asenkron
            string content = await File.ReadAllTextAsync("dosya.txt");
            //Encoding ile
            string contnt = await File.ReadAllTextAsync("dosya.txt", System.Text.Encoding.UTF8);
            //Küçük dosyalar için kullanılır. 
            string[] lines = await File.ReadAllLinesAsync("dosya.txt");

            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
            //B Dosya Yazma Yöntemleri
            string words = "Merhaba Burak!";
            await File.WriteAllTextAsync("dosya.txt", words); //Bu yöntem üzerine yazar.


        }
    }
}
