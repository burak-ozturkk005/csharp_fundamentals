namespace inherit;
//Base Class
public class Hayvan
{
    public void kendi()
    {
        Console.WriteLine("Kedi olusturuldu.");
    }
    public void Yuru()
    {
    Console.WriteLine("Hayvan yürüyüşü");
    }
}
//Derived Class
public class Kopek : Hayvan
{
    
    public Kopek() : base()//Turemis sınıf,kendi yapıcı metodunda taban sınıfın yapıcı metodunu çağırabilir.
    {
        Console.WriteLine("Kopek olusturuldu..");
    }
    public void Havla()
    {
        Console.WriteLine("Hav hav");
    }
}
public class Orangutan : Hayvan
{
    public void Ye()
    {
        Console.WriteLine("Muzu yedi.");
    }
}




