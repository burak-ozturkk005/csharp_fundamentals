string ad = "Jason";
string soyad = "Statham";
string fullName = ad + " " + soyad;
//String nasıl oluşturulur ?
string s2 = new string('A', 5); //"AAAAA"
char[] harfler = { 'H', 'e', 'l', 'l', 'o' };
string s3 = new string(harfler);
//Bazı metotlar
string text = "Hello World1";
int uzunluk = text.Length;
char ilk = text[0];
bool iceriyorMu = text.Contains("C#");
bool basliyorMu = text.StartsWith("H");
bool bitiyorMu = text.EndsWith("1");
Console.WriteLine(iceriyorMu);
Console.WriteLine(basliyorMu); //true
Console.WriteLine(bitiyorMu); //true
string x = "burak";
Console.WriteLine(x.ToUpper()); //"BURAK"
Console.WriteLine(x.ToLower()); //"burak"
string yazi = "csharp ogren";
//Kesme ve parçalama
Console.WriteLine(yazi.Substring(0,6)); //"csharp"
string[] kelimeler = yazi.Split(' '); // {"csharp", "ogren"}
string letters = "abcdefg";

Console.WriteLine(letters.Substring(3));