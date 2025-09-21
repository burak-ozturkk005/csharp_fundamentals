namespace re_ou
{
    internal class Program
    {
        public static void Arttir(ref int sayi)
        {
            sayi++;
        }
        internal static void Foo(int x)
        {
            x = 99; //çağıranı etkliemez.
        }
        internal static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        internal static bool TryDivide(int a,int b, out int result)
        {
            if(b == 0) { result = 0; return false; }
            result = a / b;
            return true;
        }
        static void Main(string[] args)
        {
            //REF ve OUT
            //Farkları, ne zaman atanmış olmak zorunda oldukları ve çağıranı nasıl etkiledikleri üzerinedir. Kopyaları ve gereksiz allocationları azaltırız. allocation: Bir şeyi belirli şeylere paylaştırma.
            int a = 5;
            Foo(a); //a hala 5
            int x = 3, y = 7;
            Swap(ref x, ref y);
            //---------------------------------
            //out: içeride üretip dışarı ver.
            //Argüman mertot içinde mutalka atanmalı. (yoksa derleme hatası)
            //çağrılmadan önce atanmış olmasına gerek yok.
            if(TryDivide(10,2,out var r))
                Console.WriteLine(r);
        }
    }
}
