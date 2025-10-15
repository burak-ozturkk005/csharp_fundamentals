//Event nedir ?: Bir olay olduğunda tetiklenen mekanizmadır.
namespace vtns
{
    public delegate void Bildirim(string mesaj);

    public class Publisher
    {
        public event Bildirim Bildir; // event
    }
    public class HaberKaynagi
    {
        public delegate void HaberHandler(string haber);

        public event HaberHandler HaberYayinlandi;
        public void YeniHaber(string haber)
        {
            Console.WriteLine("Yayıncı: " + haber);
            //Event i tetikle.
            HaberYayinlandi?.Invoke(haber);
        }
    }
    public class Abone
    {
        public void HaberAl(string haber)
        {
            Console.WriteLine("Abone haberi aldı: " + haber);
        }
    }
    class Program
    {
        static void Main()
        {
            HaberKaynagi kaynak = new HaberKaynagi();
            Abone ali = new Abone();
            Abone burak = new Abone();
            kaynak.HaberYayinlandi += ali.HaberAl;
            kaynak.HaberYayinlandi += burak.HaberAl;

            // Yeni haber yayınla
            kaynak.YeniHaber("C# Events konusuna geçildi.");
        }
    }
}