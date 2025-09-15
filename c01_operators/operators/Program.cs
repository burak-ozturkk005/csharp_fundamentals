using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
// Toplama Addition
int result;
int a = 7, b = 4;
result = (a + b); //Addition operator '+'
Console.WriteLine("Result is :" + result);
//Cikarma Substraction
result = ( a - b); //Substraction operator '-'
Console.WriteLine("Result is :" + result);
//Carpma Multiplication
result = (a * b); //Multiplication operator '*'
Console.WriteLine("Result is :" + result);
//Bolme Divide
result = ( a / b); //Divide operator '/'
Console.WriteLine("Result is :" + result);
//Mod alma Modulo
result = (a % b); // Moduloo operator '%'
Console.WriteLine("Result is :" + result);
//Increment
int c = 4,sonuc;
// Önce değeri yazdır sonra arttır.
sonuc = c++; // sonuc = 4, c = 5
Console.WriteLine(sonuc); // 4
sonuc = ++c; // c=6, sonuc = 6
Console.WriteLine(sonuc); // 6
//Relational Operators
// ==, !=, >,<, >=, <=
//Logical && = AND
//Logical || = OR
//Logical ! = NOT
//Assignment Operators
//= atama
double d = 20;
//Add Assignment +=
//(a += b) =  a = a + b
// -=
// a -= b = a = a - b;
// a *= b = a = a*b;
// a / b = a = a/b;
// a % b = a = a%b; 
//TERNARY IF
//condition ? first_expression : second_expression;
 int x = 5, y = 10;
int ze;
 ze = x < y ? x : y;
 Console.WriteLine(ze);