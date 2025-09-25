// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("-------- Aufgabe 2 --------");
int variable1 = 10;
float variable2 = 5.6f;
string variable3 = "Dies ist ein String";
Console.WriteLine(variable1.GetType());
Console.WriteLine(variable2.GetType());
Console.WriteLine(variable3.GetType());

Console.WriteLine("-------- Aufgabe 3 --------");
string name_normal = "Tatjana";
Console.WriteLine(name_normal.ToUpper());
Console.WriteLine(name_normal.ToLower());
string reversed = new string(name_normal.Reverse().ToArray());
Console.WriteLine(reversed);

Console.WriteLine("-------- Aufgabe 3 --------");
Console.Write("Gib ein Wort ein:");
string wort_1 = Console.ReadLine();
Console.Write("Gib ein zweites Wort ein:");
string wort_2 = Console.ReadLine();
Console.WriteLine($"{wort_1} {wort_2}");

Console.WriteLine("-------- Aufgabe 4 --------");
Console.Write("Zahl 1 eingeben:");
string zahl_1 = Console.ReadLine();
int zahl1 = int.Parse(zahl_1);
Console.Write("Zahl 2 eingeben:");
string zahl_2 = Console.ReadLine();
int zahl2 = int.Parse(zahl_2);

int resultat_addieren = zahl1 + zahl2;
Console.WriteLine($"Plus: {resultat_addieren}");

int resultat_subtrahieren = zahl1 - zahl2;
Console.WriteLine($"Minus: {resultat_subtrahieren}");

int resultat_multiplizieren = zahl1 * zahl2;
Console.WriteLine($"Multiplikation: {resultat_multiplizieren}");

int resultat_dividieren = zahl1 / zahl2;
Console.WriteLine($"Division: {resultat_dividieren}");

Console.WriteLine("-------- Aufgabe 5 --------");
int x = 5;
Console.WriteLine(x += 1);
Console.WriteLine(x -= 2);

Console.WriteLine("-------- Aufgabe 6 --------");
double preis_riegel = 3.20;
double geld = 20;
int anzahl_riegel = (int)(geld / preis_riegel);
Console.WriteLine(geld - anzahl_riegel * preis_riegel);
// 6 Riegel kann man kaufen
// 80 rp. bleiben übrig

Console.WriteLine("-------- Aufgabe 7 --------");
