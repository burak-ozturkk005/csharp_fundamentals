//Geriye Değer Döndüren Methodlar

public class Program
{
    public static int Square(int number)
        {
            int result = number * number;
            return result; //Metodun geriye değer dondurmesi, bu degeri baska bir degiskende saklamak veya dogrudan basla islemlerde kullanmak
            //icin faydalidir.
        }
    public static void Main(string[] args)
    {
        int number = 5;
        int squaredNumber = Square(number);
        System.Console.WriteLine("Square of " + number + " is " + squaredNumber);
       
    }
}