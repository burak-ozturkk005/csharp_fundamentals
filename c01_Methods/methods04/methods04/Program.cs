    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method OVERloading(Çoklu Yükleme)
            //Over loading: Çoklu Yükleme
            //alttakine overloading yapılmıştır.
            //metot overloading işlemi yapabilmek için metotların isimleri aynı olmalıdır.
            //Bu metotlar içerisinde fark yaratmamız gerekmektedir.
            //Metptşar arasomda farkı yaratırken erişim belirliyicileri ve geri dönüş değerleri aktif rol
            //oynamamktadır.
            //PArametre sayıları ya da parametre türleri farklı olmalıdır.
            #endregion
        }
        class Matematik
        {
         
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Topla(int sayi1,int sayi2,int sayi3)
            {
                return sayi1 + sayi2 + sayi3;
            }
        }
    }
