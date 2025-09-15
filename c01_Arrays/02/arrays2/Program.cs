//Dizi(Array) tanımlama

#region İlk Varyasyon
int[] yaslar = new int[5];
yaslar[2] = 453;
#endregion

#region İkinci varyasyon
string[] thy = {"airbus","boeing"};
#endregion

#region Üçüncü Varyasyon
char[] letter = new char[] {'b','c','d'};
#endregion

#region Dorduncu Varyasyon
string[] bikes = new string[3] {"kawasaki","honda","yamaha"};
//when we defined array number, we have to assign it equal to array members

#endregion

#region En iyi Varyasyon
var numbers = new[] {3,5,8}; //var değikeni ile tanımlama yapılırken, arrayin tipi belirtilmez.
//Array elemanının tipini alır.
#endregion
#region Value Assignment 1
Array arr = new int[3];
arr.SetValue(9,0);
arr.SetValue(7,1);
arr.SetValue(900,2);
object? value = arr.GetValue(1);
Console.WriteLine(value);
#endregion
#region VA 2
int[] arr45 = new int[3];
arr45[0] = 34;
arr45[1] = 73;
#endregion
#region Clear Method
Array rword = new[] {"m1a2","t-90","leopard2a7v"};
for(int i = 0;i<rword.Length; i++)
{
    Console.WriteLine(rword.GetValue(i));
Array.Clear(rword,0,rword.Length);
}
for(int i = 0; i<rword.Length;i++)
{
    Console.WriteLine(rword.GetValue(i));
}
#endregion
#region  Copy Method
int[] arr67 = {1,2,3,4,5};
//Array.Copy(rword, arr67,rword.Length);
//Array.Copy(rword, 2,arr67, 0,2);
#endregion
int[,,] b = new int[1,2,3];

