
public class Program
{
    static void Main(string[] args)
    {
        Gunler bugun = Gunler.Cumartesi;
        Console.WriteLine(bugun); // Cumartesi
        Console.WriteLine((int)bugun);
        foreach (var gun in Enum.GetValues(typeof(Gunler)))
        {
            Console.WriteLine(gun);
        }
        Console.ReadKey();
    }
        enum Gunler
                    {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
                     }
    
    }

