using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _1
{
    internal class Program
    {
        public delegate int Hesaplama(int x, int y); //delegate tanımı
        //uyan metotlar
        public delegate void Mesaj();
        public static void Selam() => Console.WriteLine("Selam!");
        public static void Bye() => Console.WriteLine("Görüşürüz!");
        public static int Topla(int x, int y) => x + y;
        public static int Carp(int x, int y) => x * y;
     
        static void Main(string[] args)
        {
            //Delegate bir tiptir. (class gibi) ama metotları işaret eder.
            //Parametre listesi ve dönüş tipi sabittir. > o imzaya uyan her metodu işaret edebilir.
            //tanımlanır,instance alınır içine metot atanır. çağırılır.
            Hesaplama hesap = Topla; //class gibi oluşturduk ve metodu hesaplaya eşitledik.
            Console.WriteLine(hesap(3,4));
            hesap = Carp; // başka metoda eşitledik.
            Console.WriteLine(hesap(4,5));
            Mesaj m = Selam;
            m += Bye;
            m();
            //Built-in Delegates (Kolaylık için)
            Func<int, int, int> topla = (a, b) => a + b;
            Console.WriteLine(topla(5,9)); // 14
            Action<string> yaz = msg => Console.WriteLine(msg);
            yaz("Merhaba Buraki");
            Predicate<int> ciftMi = X => X % 2 == 0;
            Console.WriteLine(ciftMi(4)); //true
        }
    }
}
