namespace prc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Burak";
            ogr.Soyad = "Jason";
            ogr.Not = 75;
            ogr.NotGoster();
        }
    }
}
