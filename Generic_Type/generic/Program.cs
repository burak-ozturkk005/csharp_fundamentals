/* Generics,, veri tipinden bağımsız olarak çalışabilen sınıf, metod ve yapıların tanım
lanmasına olanak sağlar. Bu, kodun tekrar kullanılabilirliğini artırır ve tür güvenliği
sağlar.
*/
using System.ComponentModel.DataAnnotations;
using generic;

generic_class<int> intInstance = new generic_class<int>(19);
Console.WriteLine(intInstance.GetData());

generic_class<string> stringInstance = new generic_class<string>("Hi Burak");
Console.WriteLine(stringInstance.GetData());
//Generic MEthod
void Display<T>(T value)
{
    Console.WriteLine(value);

}
Display<int>(123);
Display<string>("GEneric MEthod");