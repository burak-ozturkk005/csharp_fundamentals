using System.ComponentModel.Design;

namespace generic00
{
    public class Cift<T>
    {
        private T Deger;
        private T Deger2;
        public Cift(T deger,T deger2)
        {
            Deger = deger;
            Deger2 = deger2;
        }
        public T[] GeriDondur()
        {
            T[] arr = new T[] {Deger,Deger2};
            return arr;
        }
    }
    public class Depolayici<T>
    {
        private T deger;
        public void Ekle(T item)
        {
            deger = item;
        }
        public T Getir()
        {
            return deger;
        }

    }
    public class HerseyiDepolayici
    {
        private object deger;
        public void Ekle(object item)
        {
            deger = item;
        }
        public object Getir()
        {
            return deger;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic nedir ? Aynı mantığı farklı tiplerle kullanmak için bir şablon.
            var depo = new HerseyiDepolayici();
            depo.Ekle(42);
            int sayi = (int)depo.Getir(); //Cast exception hatası.
            var sayiDepo = new Depolayici<int>();
            sayiDepo.Ekle(42);
            int sayi1 = sayiDepo.Getir();
            var stringDepo = new Depolayici<string>();
            stringDepo.Ekle("Selam");
            string metin = stringDepo.Getir();
            var sayiDepo3= new Depolayici<int>();
            //sayiDepo3.Ekle("Selam");// compile error
            var intCift = new Cift<int>(10, 20);
            var sonuc = intCift.GeriDondur();
            foreach(var n in sonuc)
            {
                Console.WriteLine(n);
            }
            var stringCift = new Cift<string>("MErhaba", "Dünya");
            var snc = stringCift.GeriDondur();
           foreach(var n in snc)
            {
                Console.WriteLine(n);
            }
        }
    }
}
