using System;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

string cesta = "C:\\Users\\user\\Desktop\\domaciUkol.txt";

// 1. VYtvoř program podobný tomu, který jsi dělala v breakout roomu na lekci.

//Tedy načítej řádky, dokud není načtený prázdný řádek a zapisuj je do souboru.

//Následně obsah souboru vypiš.
//File.WriteAllText(cesta, String.Empty);

//Console.WriteLine("Paste the text:");

//while (true)
//{
//    string line = Console.ReadLine(); //přečte jeden řádek konzole
//    if (string.IsNullOrEmpty(line))
//    {
//        break; //při odentrování se ukončí ukládání
//    }
//    line += ' ';
//    File.AppendAllText(cesta, line);
//}

//string radek = File.ReadAllText(cesta);


//Console.Write("Obsah souboru, kde jsou slova oddělená mezerou: " + radek); 

//2 udělej na úvod menu jestli chce uživatel přidávat řádky nebo vypsat soubor.

Console.Clear();
Console.WriteLine("Vyberte si:");
Console.WriteLine("1) Uložit do souboru");
Console.WriteLine("2) Vypsat soubor");
Console.WriteLine("3) Vymazat soubor");
Console.WriteLine("4) Exit");


switch (Console.ReadLine())
{
    case "1":
        UlozitDoSouboru();
        break;
    case "2":
        VypsatObsahSouboru();
        break;
    case "3":
        VymazatObsahSouboru();
        break;
    case "4":
        return;
}

void VymazatObsahSouboru()
{
    File.WriteAllText(cesta, string.Empty);
}
void UlozitDoSouboru()
{
    Console.WriteLine("Paste the text:");
    bool jePrazdnyRadek = false;
    while (!jePrazdnyRadek)
    {
        string line = Console.ReadLine(); //přečte jeden řádek konzole
        if (string.IsNullOrEmpty(line))
        {
            jePrazdnyRadek = true; //při odentrování se ukončí ukládání
        }
        line += ' ';
        File.AppendAllText(cesta, line);
    }
}
void VypsatObsahSouboru()
{
    string radek = File.ReadAllText(cesta);

    Console.Write("Obsah souboru, kde jsou slova oddělená mezerou: " + radek);
}

//Jak zařídit, aby se po každé operaci znovu vypsala nabídka?