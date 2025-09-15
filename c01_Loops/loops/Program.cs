//C# da donguler, belirli bir koşul sağlandığı surece tekrar eden işlemleri gerçekleştirmek için kullanılır.

#region For Dongusu
for(int d = 2; d < 10; d++)
{
    //Dongu govdesi
    //i değişkeni 2'den başlayarak 10'a kadar 1'er 1'er artarak döngüyü gerçekleştirir.
}
//Ornek
for(int l = 0; l< 100; l++)
{
    Console.WriteLine(l);
}
#endregion

#region While Dongusu
int i = 0;
while(i < 25)
{
    //Dongu govdesi
    Console.WriteLine(i);
    i++;
}
#endregion
#region Do-While Dongusu
//Koşul sağlanıp sağlanmadığını kontrol etmeden en az bir kez çalıştıran döngüdür.
//Kullanıcıdan veri alma gibi durumlarda yaygın olarak kullanılır.
string input;
do
{
    Console.WriteLine("Devam etmek için evet yazın");
    input = Console.ReadLine();
} while (input != "evet");
    Console.WriteLine("Program sonlandı.");
#endregion

#region Foreach Dongusu
//diziler, listeler (List<T>) ve koleksiyonlar üzerinde elemanları tek tek gezmek için kullanılır.
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
#endregion

#region Break ve Continue
//Break: Döngüyü sonlandırmak için kullanılır.
//Continue: Döngüde bir sonraki adıma geçmek için kullanılır.
for (int a = 0; a < 10; a++)
{
    if (a == 5)
    {
        break;
    }
    Console.WriteLine(i);
}
for (int b = 0; b < 10; b++)
{
    if (b == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}
#endregion