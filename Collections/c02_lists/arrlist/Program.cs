using System.Collections;

namespace arrlist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tanımlama
            ArrayList arrayList = new ArrayList();
            //Ekleme
            arrayList.Add(120); //boxing yapılıyor.
            //object türünde veri tutarlar.
            arrayList.Add("selam burak");
            arrayList.Add(true);
            arrayList.Add('b');
            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }
            //elemana erişme
            Console.WriteLine(arrayList[3]);
            //silme işlemi
            arrayList.Remove(arrayList[0]);
            
        }
    }
}
