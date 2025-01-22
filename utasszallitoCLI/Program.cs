using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\ny20keresztúrih\\Desktop\\UTASSZALLITOK\\utasszallitok.txt";

        List<string> sorok = new List<string>(File.ReadAllLines(filePath));

        //4.feladat
        int tipusok = 0;
        foreach (string sor in sorok)
        {
            tipusok++;
        }
        Console.WriteLine("4.feladat: Adatsorok száma " + (tipusok - 1));

        //5.feladat
        int boeing = 0;
        foreach (string sor in sorok)
        {
            if (sor.Contains("Boeing"))
            {
                boeing++;
            }
        }
        Console.WriteLine("5.feladat: Boeing típusok száma: " + boeing );

        //6.feladat

        /*Console.WriteLine("6.feladat: A legtöbb utatst szállító repülőgép típus: \n" +
            "Típius: " + +"\n" +
            "Első felszállás: " + + "\n" +
            "Utasok száma: " + + "\n" +
            "Személyzet: " + +"\n" +
            "Utazósebesség: "+ + );
       */

        //7.feladat
        

    }
}

