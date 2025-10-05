//Interface nedir ?
//Interface bir sınıfın hangi davranışlara sahip olacağını tanımlar ama nasıl olacağını söylemez.
//Yani sadece imza vardır. İçerik (implementation) yoktur.
//Bir class birden fazla interface i implement edebilir.
/* Kim interface i implemnent ederse Calistir ve Durdur(IArac interface e bak) metotlarını yazmak zorunda.
 * interface ler büyük projelerde bağımlılığı azaltmak için kritik.
 * Mesela veri kaydetme işlemini hem SQLRepository hem FileRepository yapabilir. Ama interface sayesinde kodunu değiştirmeden istediğini çağırabilirsin.
 * */