namespace exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SORU
             * bir liste oluştur.
             * Kullanıcıdan 5 tane sayı al ve listeye ekle.
             * Listenin toplamını en büyük sayısını ve en küçük sayını bul.
             * */
            int input;
            List<int> sayilar = new List<int>();
            int toplam = 0;
            int max = 0;
            int min = 0;
            Console.WriteLine("5 adet sayi girin: ");
                for (int i = 0; i < 5; i++)
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    sayilar.Add(input);
                    toplam += input;
                    if(i == 0)
                {
                    min = input;
                    max = input;
                }else
                {
                    if (input < min) min = input;
                    if (input > max) max = input;
                }
            }
           
                foreach(var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine($"Toplam: {toplam}");
                Console.WriteLine($"en kucuk sayi: {min} ");
            Console.WriteLine($"en buyuk sayi: {max}");
        }
    }
}
