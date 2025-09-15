//String Interpolation
string firstName = "Burak";
string message = $"Hello {firstName}!";
//
double version = 4.5;
string software = "Planner_App";
string caution = $"Please update {software} version to {version} or click down below to close app.";
Console.WriteLine(caution);
//
string projectName = "first-Project";

Console.WriteLine($"C:\\Output\\{projectName}\\Data"); // You can see one reverse bracket does not shown.
Console.WriteLine($@"C:\\Output\\{projectName}\\Data"); //  "@" sembol is allows you to write \\ 

Console.WriteLine($"Bye bye \t\tLonelines.."); // \t is tab.
Console.WriteLine($"Hi my  friend.\" asdasd"); // \" displays double quotes.


