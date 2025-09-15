namespace Polymorphism;
//Polymorphism, aynı arayüz veya temel sınıfı paylaşan farklı sınıf örneklerinni, aynı işelve farklı
//şekillerde tepki verebilmesi anlamına gelir.
//POLYMORPHISM 2 şekilkde ortaya çıkar
//1- Compile-Time Polymorphism (Derleme zamanı )
//1-aMethod Overloading:
//1-bOperator Overloading
//2-Run-Time Polymorphism(Çalışma Zamanı)
//2-aMethod OVerriding (metot ezme)

public class Polymorphism
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan sesi");
    }
}
public class Dog: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Havla Bark");
    }
}
