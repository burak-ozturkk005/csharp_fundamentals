//Şuanki zamanı almak
DateTime simdi = DateTime.Now;
Console.WriteLine(simdi); // 30.09.2025 11.09
//sadece tarihi almak
DateTime bugun = DateTime.Today;
Console.WriteLine(bugun); //30.09.2025 00:00:00
//manuel oluşturmak
DateTime dt = new DateTime(2025, 9, 30, 14, 45, 0);
Console.WriteLine(dt); // 30.09.2025 14:35:00

Console.WriteLine(simdi.Year);   // 2025
Console.WriteLine(simdi.Month);  // 9
Console.WriteLine(simdi.Day);    // 30
Console.WriteLine(simdi.Hour);   // 15
Console.WriteLine(simdi.Minute); // 42
Console.WriteLine(simdi.Second); // 10
Console.WriteLine(simdi.DayOfWeek); // Tuesday
//Gun ekleme
DateTime bgn = DateTime.Today;
DateTime yarin = bgn.AddDays(1);
DateTime dun = bugun.AddDays(-1);

Console.WriteLine(yarin);
Console.WriteLine(dun);
