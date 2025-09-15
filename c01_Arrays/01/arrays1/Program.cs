#region Dizi Tanımlama 
//int[] arr = new int[arr.Length];
//Dizilerde önceden eleman sayısını belirtmek gibi zorunluluklar vardır.
int[] arr1 = new int[10]; // >> Burada oldugu gibi.
#region 2. variation
var number2 = new[] { 1, 2, 3, 4 };
//var is assigned when array's members defined..
#endregion
#region Create Array With CreateInstance MEthod
int[] values = new int[3]; //This is also calls on background CreateInstance Method.
Array values1 = Array.CreateInstance(typeof(int), 3); // We can also use this method.
#endregion
#endregion
#region Dizideki elemanları çağırma.
int[] yaslar = new int[] { 1, 3, 5, 7 };
yaslar[3] = 5; // Dizi elemanı tanımlar ya da değiştirirken herhangi bir sırada olmak zorunda değildir.
yaslar[2] = 16;
yaslar[0] = 27;
Console.WriteLine(yaslar); // dizileri çağırırken dizi adını doğrudan yazdıramayız.çünkü Console.WriteLine
//ToString() metodunu çağırır. ToString() metodu da  Ram üzerindeki adresini gösterir.
foreach (int i in yaslar) // Eğer elemanları yazdırmak istersek foreach for gibi döngü yapılarını kullanabiliriz.
    Console.WriteLine(i);
#endregion
#region Substring Methodu
string text = "Merhaba Burak";
string result = text.Substring(8); // Burak
Console.WriteLine(result);
//2 paremetreli Substring
string text1 = "merhaba oop";
string result1 = text1.Substring(3,3); //hab
Console.WriteLine(result1);
#endregion
#region Indexof Methodu
//dizide bir elemanın var olup olmadığı sorgusudur.
string[] words = new string[3] { "Ali", "Jason", "Burak" };
int index2 = Array.IndexOf(words, "Burak", 0, 3); // ilk parametre dizi ismi, ikincisi başlangıc indeksi,
// üçüncüsü ise ne kadar count.
//Eğer eleman yoksa -1 döndürür.
Console.WriteLine(index2);
#endregion
#region Reverse MEthod
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words.GetValue(i));
}
Array.Reverse(words);
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words.GetValue(i));
}
#endregion
