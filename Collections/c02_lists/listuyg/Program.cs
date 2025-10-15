namespace listuyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Bursa",
                "İzmir"
            };
            foreach (var s in sehirler)
            {
                Console.WriteLine(s);
            }
            sehirler.ForEach(s => Console.WriteLine(s));
            var iller = sehirler;
            //List<string> = List<string>
            iller.ForEach(i => Console.WriteLine(i));
        }
    }
}
