namespace st00
{
    public struct Ogrenci
    {
        public Ogrenci(int ogrenciNo, string ad, string soyadi, bool cinsiyet)
        {
            OgrenciNo = ogrenciNo;
            Ad = ad;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        private bool Cinsiyet { get; set; } //dışarıyı ilgilendirmiyor onun için private

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct Değer tipli veri türü
            //Parametreli yapılandırıcı metot,sabitler,alan(field),özellik(property)
            //küçük ölçekli veriler üzerinde kullanılır.
            //Kalıtım(Inheritance) yoktur.
            //Arayüz kalıtım (interface inheritance) destekler.
            //struct tanımlama
            Ogrenci ogr = new Ogrenci();
            ogr.OgrenciNo = 45;
        }
    }
}
