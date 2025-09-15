//Birlestirme Concat 1.

string name = "burak";
string lastName = "asdsd";
string fullName = name + " " + lastName;
//2.
string nameConcat = String.Concat(name," ",lastName);
Console.WriteLine("This is concat: " + nameConcat);
//Ayrıştırıp bir alt satıra geçme Split 
string message = "Hey burak what's up ?";

string[] words = message.Split(' '); //o karakteri gördüğü her yerde bi alt satıra geçiyor. '  '
foreach(string word in words)
{
     Console.WriteLine(word);
}
//Uzunluk, Length
string str = "OBjective_C"; // Not: Length 0 dan baslamaz index 0 dan baslar.

bool dogru = str.Length == 11 ? true : false;
Console.WriteLine(dogru);
//Substring Method :Belirli bir bölümü kesip ekrana yazdır.
string str_A ="Istanbul_Besiktas";
string substring = str_A.Substring(1,5); // 0 = baslangic index, 3 bitis index ama DAHIL DEGIL.
Console.WriteLine(substring);
//Replace Belirtilen karakterleri yenisiyle degistirir.
string str_B = "Hello, World";
string newStr = str_B.Replace("World", "C#");
// to lower to upper
string str3 = "Burak";
string lowerStr = str3.ToLower();
string upperStr = str3.ToUpper();


