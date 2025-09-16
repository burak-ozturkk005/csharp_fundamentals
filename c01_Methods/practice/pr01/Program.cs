using System.ComponentModel;

namespace pr01
{
    internal class Program
    {
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Carp (int a,int b,int c)
        {
            return a * b * c;
        }
        //ref
        public static void Arttir(ref int x)
        {
            x++;
        }
        //out
        public static void Bol(int a,int b, out int bolum, out int kalan)
        {
            bolum = a / b;
            kalan = a % b;
        }
        public static void Mesaj(string isim = "Ziyaretçi")
        {
            Console.WriteLine("MErhaba " + isim);
        }

        static void Main(string[] args)
        {
            //ref de değişkeni referansla yollar, içeride değiştirilirse dışarıda da değişir.
            //out metottan ekstra değer döndürmeye yarar(return dışında).
            int sayi = 5;
            Arttir(ref sayi);
            Console.WriteLine(sayi); // 6;
            int bolum, kalan;
            Bol(10, 3, out bolum, out kalan);
            Console.WriteLine($"{bolum}, {kalan}"); // 3,1
            //Default Parametre 
            Mesaj("Burak");
        }
    }
}
