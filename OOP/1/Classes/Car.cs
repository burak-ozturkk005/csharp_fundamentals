namespace Classes;

public class Car
{
    public string Model = "535i";
    public string Year = "1999";
    //Method
    public void Introduce()
    {
        Console.WriteLine($"This car is a {Model}  &  {Year}.");
    }
}
