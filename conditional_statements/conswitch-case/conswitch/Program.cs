/*
switch (value)
{
    case sabit1:
        // Kodlar
        break;

    case sabit2:
        // Kodlar
        break;

    default:
        // Hiçbiri değilse burası
        break;
}
*/
int gun = 3;

switch (gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    default:
        Console.WriteLine("Geçersiz gün");
        break;
}
//sadece sabit değerler ile çalışır. Koşullu mantıklar ile kullanılamaz. Böyle durumda if-else gerekir.