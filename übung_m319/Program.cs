// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("-------- Aufgabe 2 --------");
// int variable1 = 10;
// float variable2 = 5.6f;
// string variable3 = "Dies ist ein String";
// Console.WriteLine(variable1.GetType());
// Console.WriteLine(variable2.GetType());
// Console.WriteLine(variable3.GetType());

// Console.WriteLine("-------- Aufgabe 3 --------");
// string name_normal = "Tatjana";
// Console.WriteLine(name_normal.ToUpper());
// Console.WriteLine(name_normal.ToLower());
// string reversed = new string(name_normal.Reverse().ToArray());
// Console.WriteLine(reversed);

// Console.WriteLine("-------- Aufgabe 3 --------");
// Console.Write("Gib ein Wort ein:");
// string wort_1 = Console.ReadLine();
// Console.Write("Gib ein zweites Wort ein:");
// string wort_2 = Console.ReadLine();
// Console.WriteLine($"{wort_1} {wort_2}");

// Console.WriteLine("-------- Aufgabe 4 --------");
// Console.Write("Zahl 1 eingeben:");
// string zahl_1 = Console.ReadLine();
// int zahl1 = int.Parse(zahl_1);
// Console.Write("Zahl 2 eingeben:");
// string zahl_2 = Console.ReadLine();
// int zahl2 = int.Parse(zahl_2);

// int resultat_addieren = zahl1 + zahl2;
// Console.WriteLine($"Plus: {resultat_addieren}");

// int resultat_subtrahieren = zahl1 - zahl2;
// Console.WriteLine($"Minus: {resultat_subtrahieren}");

// int resultat_multiplizieren = zahl1 * zahl2;
// Console.WriteLine($"Multiplikation: {resultat_multiplizieren}");

// int resultat_dividieren = zahl1 / zahl2;
// Console.WriteLine($"Division: {resultat_dividieren}");

// Console.WriteLine("-------- Aufgabe 5 --------");
// int x = 5;
// Console.WriteLine(x += 1);
// Console.WriteLine(x -= 2);

// Console.WriteLine("-------- Aufgabe 6 --------");
// double preis_riegel = 3.20;
// double geld = 20;
// int anzahl_riegel = (int)(geld / preis_riegel);
// Console.WriteLine(geld - anzahl_riegel * preis_riegel);
// // 6 Riegel kann man kaufen
// // 80 rp. bleiben übrig

// Console.WriteLine("-------- Aufgabe 7 --------");
// Console.Write("Zahl 1 eingeben:");
// string zahl_vergleichen_1 = Console.ReadLine();

// Console.Write("Zahl 2 eingeben:");
// string zahl_vergleichen_2 = Console.ReadLine();

// int zahl_1_umwandeln = int.Parse(zahl_vergleichen_1);
// int zahl_2_umwandeln = int.Parse(zahl_vergleichen_2);

// if (zahl_1_umwandeln > zahl_2_umwandeln)
// {
//     Console.WriteLine("die Zahl 1 ist grösser.");
// }
// else if (zahl_1_umwandeln == zahl_2_umwandeln)
// {
//     Console.WriteLine("die Zahlen sind gleich.");
// }
// else if (zahl_1_umwandeln < zahl_2_umwandeln)
// {
//     Console.WriteLine("die Zahl 2 ist grösser.");
// }

// Console.WriteLine("-------- Aufgabe 8 --------");
// int zahl_zwischen_10_und_20 = 17;

// if (zahl_zwischen_10_und_20 >= 10 && zahl_zwischen_10_und_20 <= 20)
// {
//     Console.WriteLine("die Zahl ist zwischen 10 und 20");
// }

// if (zahl_zwischen_10_und_20 < 0 || zahl_zwischen_10_und_20 > 100)
// {
//     Console.WriteLine("die Zahl ist kleiner als 0 oder grösser als 100");
// }
// else
// {
//     Console.WriteLine("die Zahl ist nicht kleiner als 0 oder grösser als 100");
// }

// Console.WriteLine("-------- Aufgabe 9 --------");
// Console.Write("Gib ein Passwort ein:");
// string passwort = Console.ReadLine();

// if (passwort.Length <= 8)
// {
//     Console.WriteLine("Das passwort ist valide.");
// }
// else
// {
//     Console.WriteLine("Das Passwort ist zu lange.");
// }

// Console.WriteLine("-------- Aufgabe 10 --------");
// Console.WriteLine("Wie schnell fährt dein Auto? (in km)");
// double geschwindigkeit = double.Parse(Console.ReadLine());

// Console.WriteLine("Wie hoch ist der Benzin-Verbrauch pro 100km?");
// double benzin_verbrauch = double.Parse(Console.ReadLine());

// Console.WriteLine("Wie viel willst du fahren? (Distanz in km)");
// double distanz = double.Parse(Console.ReadLine());

// double fahrzeitStunden = distanz / geschwindigkeit;
// double fahrzeitMinuten = fahrzeitStunden * 60;

// double gesamtverbrauch = distanz * benzin_verbrauch / 100;

// Console.WriteLine($"Fahrzeit: {fahrzeitMinuten:F2} Minuten");
// Console.WriteLine($"Benzinverbrauch: {gesamtverbrauch:F2} Liter");

// Console.WriteLine("-------- Aufgabe 11 --------");
// Console.Write("Gib deine Grösse an (in Meter):");
// double groesse = double.Parse(Console.ReadLine());

// Console.Write("Gib dein Gewicht an (in kg):");
// double gewicht = double.Parse(Console.ReadLine());

// double groesse_mal_groesse = groesse * groesse;
// double ergebnis = gewicht / groesse_mal_groesse;
// Console.WriteLine($"dein BMI: {ergebnis:F2}");

Console.WriteLine("-------- Aufgabe 12 --------");
Console.Write("Anzahl Stunden:");
double stunden = double.Parse(Console.ReadLine());

Console.Write("Anzahl Minuten:");
double minuten = double.Parse(Console.ReadLine());

Console.Write("Anzahl Sekunden:");
double sekunden = double.Parse(Console.ReadLine());

double minuten_in_stunden = minuten / 60;
double sekunden_in_stunden = sekunden / 3600;
double ergebnis_dezimal = stunden + minuten_in_stunden + sekunden_in_stunden;
Console.WriteLine(ergebnis_dezimal);