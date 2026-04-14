// See https://aka.ms/new-console-template for more information
using OOP_TAR_25;

// Loome Isik klassi objekti ja kasutame selle omadusi ja meetodit
//Isik inimene1 = new Isik();

//inimene1.Nimi = "Mati";
//inimene1.Sünniaasta = 200;
//inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

// Klassi Õpilane ja Õpetaja näited.
// Päritud Isik klassist, seega saavad kasutada Isiku omadusi ja meetodeid
Õpetaja õpetaja1 = new Õpetaja();
õpetaja1.Nimi = "Eve";
õpetaja1.Sünniaasta = 1980;
õpetaja1.Aine = "Matemaatika";
õpetaja1.Tervita(); // Väljund: Tere! Mina olen Eve...
õpetaja1.Õpeta(); // Väljund: Eve õpetab ainet: Matemaatika.
õpetaja1.Kirjelda(); // Väljund: Mina olen õpetaja Eve ja ma õpetan: Matemaatika.
Console.WriteLine("\n--- Õpilase andmed ---");
// 2. Loome Õpilase objekti
Õpilane õpilane1 = new Õpilane();
// Päritud Isik klassist
õpilane1.Nimi = "Markus";
õpilane1.Sünniaasta = 2008;
// Spetsiifilised Õpilane klassile
õpilane1.Kool = "Kutsehariduskeskus";
õpilane1.Klass = 10;
// Päritud meetod
õpilane1.Tervita();
// Õpilase enda meetod
õpilane1.Õpi();
// Ootame kasutaja sisestust, et konsooliaken kohe ei sulguks
õpilane1.Kirjelda();
Console.ReadLine();