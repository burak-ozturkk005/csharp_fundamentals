namespace inherit;

public class OVERRIDE
{ 
}
public class Car
{
    public virtual void SurUzaga()
    {
        Console.WriteLine("Araba uzaga gidiyor.");
    }
}
public class Elfreni : Car
{
    public override void SurUzaga() //Ezeceğimiz metodun ismiyle aynı olmak zorunda..
    {
        Console.WriteLine("Arabanın fren balataları sıkıldı gidemez.");
    }
}