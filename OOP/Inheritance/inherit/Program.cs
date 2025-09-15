//Kalıtım Inheritance
using inherit;

Hayvan h1 = new Hayvan();
//h1.Kopek(); //
Kopek k1  = new Kopek();
k1.kendi(); // o metodu çağıracaksak illa ki o sınıftan obje oluşturmamız gerekiyor. INHERIT alsakta.

Hayvan h2 = new Hayvan();
h2.Ye(); // ÇALIŞMAZ çünkü. ORANGUTAN sınıfının metodu Ye() dir. Hayvan sınıfının değil. 
//Scope gibi düşünebiliriz.
Orangutan o1 = new Orangutan(); 
o1.Ye();
//-----OVERRIDE----
Car c2 = new Car();
c2.SurUzaga(); // Bu metodu ezdik OVERRIDE.cs e bakın.
Elfreni f1 = new Elfreni();
f1.SurUzaga(); // Metot ismi,Ezeceğimiz metodla aynı olmak zorunda. 
