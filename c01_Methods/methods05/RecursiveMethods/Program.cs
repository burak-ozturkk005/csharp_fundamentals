namespace RecursiveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {//Recursive methodlar kendi içerilerinde kendilerini çağıran metodlardır.
            int x = 10;
            SifirAyar1(ref x);
            Console.WriteLine(x); // çıktı 0 olacaktır.
        }
        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public static void SifirAyar1(ref int sayi)
        {
            sayi = 0;
        }
    }


}
