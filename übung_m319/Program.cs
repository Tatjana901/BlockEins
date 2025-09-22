// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int variable1 = 10;
float variable2 = 5.6f;
string variable3 = "Dies ist ein String";
Console.WriteLine(variable1.GetType());
Console.WriteLine(variable2.GetType());
Console.WriteLine(variable3.GetType());
Console.WriteLine("---------------");

string name_normal = "Tatjana";
Console.WriteLine(name_normal.ToUpper());
Console.WriteLine(name_normal.ToLower());
string reversed = new string(name_normal.Reverse().ToArray());
Console.WriteLine(reversed);

Console.Write("Gib ein Wort ein:");
string wort_1 = Console.ReadLine();
Console.Write("Gib ein zweites Wort ein:");
string wort_2 = Console.ReadLine();
Console.WriteLine($"{wort_1} {wort_2}");
Console.WriteLine("---------------");

Console.Write("Zahl 1 eingeben:");
int zahl_1 = Console.ReadLine();
Console.Write("Zahl 2 eingeben:");
