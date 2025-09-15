namespace generic_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo<int> intdepo = new Depo<int>();
            intdepo.Ekle(15);
            int sonuc = intdepo.Getir(0);
            Console.WriteLine("Depodaki Eleman: " + sonuc);
        }
    }
    public class Depo<T>
    {
        public List<T> items = new List<T>();

        public void Ekle(T item)
        {
            items.Add(item);
        }
        public T  Getir(int index)
        {
            return items[index];
            
        }
    }

}

