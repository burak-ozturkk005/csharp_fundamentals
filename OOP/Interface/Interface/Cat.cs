namespace Interface;

//Interface, bir sınıfın veya yapının uygulaması gereken metodların
// özelliklerin ve olayların bir listesini tanımlayan bir kalıptır.
public class Cat : IAnimal
{//Interface bahsettiğimiz methodları Classda tanımladık
//Interface ler default olarak public Erişim Belirleyicisine(Acces Modifier) Sahiptir.
//Bir sınıf birden fazla interface ı uygulayabilir.
    public void Eat()
    {
        Console.WriteLine("Kedi yemek yiyor.");
    }
    public void Run()
    {
        Console.WriteLine("Kedi koşuyor.");
    }
    public void Sleep()
    {
        Console.WriteLine("Kedi uyuyor.");
    }
}
