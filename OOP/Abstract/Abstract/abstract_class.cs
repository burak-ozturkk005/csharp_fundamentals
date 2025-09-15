namespace Abstract;

public class abstract_class
{//ABSTRACT Sınıflar türetilen sınıflar için bir kalıp sağlar ve bazı 
//metodların zorunlu olarak override edilmesini gerektirir.
//Abstract sınıflar doğrudan nesne yaratılamayan sınıflardır.
//Bu sınıflar diğer sınıflar için bir temel sınıf olarak kullanılır.
}
public abstract class Car
{
    public abstract void Run();
    //ABSTRACT Metodlar, Abstract sınıfların belirli bir davranışı zorunlu kılmak istediği durumlarda
    //KULLANILIr.
    //Abstract metodlar ABSTRACT sınıflar içerisinde tanımlanır ve gövdesi yoktur.
    //Bu metotlar türetilmiş sınıflardan mutlaka OVERRIDE edilmelidir.
    public void AutomaticWiper()
    {
        Console.WriteLine("Automatic Wipers on.");
    }
}
public class Bmw : Car
{
    public override void Run()
    {
        Console.WriteLine("SPINNING.");
    }
}
public class Dacia : Car
{
    public override void Run()//dfgdgdf
    {
        Console.WriteLine("This car has no engine.");
    }
}
