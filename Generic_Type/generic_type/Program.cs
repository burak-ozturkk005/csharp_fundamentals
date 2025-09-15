namespace generic_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tip güvenliği sağlar ve performansı artırır çünkü boxing unboxing işlemlerini azaltır.
            ObjectList list = new ObjectList();
            list.Add(42);
            list.Add("merhaba");

            int sayi = (int)list.Get(0);
            string mesaj = (string)list.Get(1);
            //Generic type kullanarak
            GenericList<int> intList = new GenericList<int>();
            intList.Add(42);
            int sayi1 = intList.Get(0);
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Merhaba");
            //Tip güvenliği sağlandı cast etmeye gerek kalmadı.
            //PErformans artar. Kod tekrarını azaltır.
            Console.WriteLine(sayi1);

        }
        public class ObjectList
        {
            private List<object> items = new List<object>();
            public void Add(object item)
            {
                items.Add(item);
            }
            public object Get(int index)
            {
                return items[index];
            }
        }
        public class GenericList<T>
        {
            private List<T> items = new List<T>();
            public void Add(T item)
            {
                items.Add(item);
            }
            public T Get(int index)
            {
                return items[index];
            }
        }
    }
}
