using System.Collections.Generic;
//Lists
List<string> names = ["<name>", "Ana", "Felipe"];
//List, C# dilinde kullanılan ve 
//System.Collections.Generic isim alanında tanımlanan genel amaçlı bir koleksiyon türüdür. 
//Bir dizi gibi, List de bir veri kümesini saklar, 
//ancak dizilerden farklı olarak, dinamik olarak büyüyüp küçülebilir.
List<int> numbers = new List<int>();

numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

foreach(int number in numbers)
{
    Console.WriteLine(number);
}
//indexten eleman erişimi
int firstNumber = numbers[0];
Console.WriteLine($"First Number: +  {firstNumber}");

numbers.Remove(3);
names.Clear(); //Listeyi temizle.
//Eleman sayısını alma. 
int numberOfNames = names.Count;
//Eleman araama 
bool hashBob = names.Contains("Bob");
