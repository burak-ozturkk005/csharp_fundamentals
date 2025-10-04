using System.Xml.Serialization;

namespace hesap_mak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen 2 adet sayi girin.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen yapmak istediginiz islemi secin (+,-,/,*)");
            string secim = Console.ReadLine();
            Func<double, double, double> hesap = null;

            if (secim == "+")
                hesap = (a, b) => a + b;
            else if (secim == "-")
                hesap = (a, b) => a - b;
            else if (secim == "*")
                hesap = (a, b) => a * b;
            else if (secim == "/")
                hesap = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            if (hesap != null)
            {
                double sonuc = hesap(x, y);
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem!");
            }

        }
    }
}
