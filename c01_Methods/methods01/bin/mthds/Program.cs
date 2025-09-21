using System.Security.Cryptography.X509Certificates;

namespace mthds
{
    internal class Program
    {
        internal static int Topla(int x, int y)
        {
            return x + y;
        }
        internal static void SelamVer()
        {
            Console.WriteLine("Merhaba Burak!");
        }
        public static void Selam(string isim)
        {
            Console.WriteLine($"Merhaba {isim}!");
        }
        public static int Topla(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            /*
             * erişim_belirleyici geri_donus_tipi MetotAdi(parametreler)
             * {
             * kodlar
             * return deger; (geri donus varsa)
             * }
             * */
            Console.WriteLine(Topla(4,5)); // ayriyeten geriye deger dondurur.
            /*Geriye deger dondurmeyen void
             *
             */
            SelamVer();
            //Parametre Alan
            Selam("Ayşe");
            //Method Overloading (aşırı yükleme
            //Aynı isimli fakat farklı parametreli metodlar.
            Console.WriteLine(Topla(4, 5, 6));
        }
    }
}
