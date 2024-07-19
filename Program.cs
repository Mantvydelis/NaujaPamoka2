using System;
using System.ComponentModel.Design;
using System.Reflection;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        //***Užduotis 1

        //public static void Main1(string[] args)
        //{
        //    Console.WriteLine("Iveskite skaiciu: ");
        //    string rezultatas = ArTeigiamas(int.Parse(Console.ReadLine()));
        //    Console.WriteLine(rezultatas);
        //}
        //public static string ArTeigiamas(int skaicius)
        //{
        //    if (skaicius > 0)
        //        return "Teigiamas";
        //    else if (skaicius == 0)
        //        return "Nulis";
        //    return "Neigiamas";
        //}

        //***Užduotis 2

        //public static void Main2(int[] args)
        //{
        //    Console.WriteLine("Iveskite pirma skaiciu:: ");
        //    Console.WriteLine("Iveskite antra skaiciu:: ");
        //    Console.WriteLine("Iveskite trecia skaiciu:: ");
        //    Console.WriteLine(Didziausias1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

        //}
        //public static int Didziausias1(int skaicius1, int skaicius2, int skaicius3)
        //{
        //    if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
        //    {
        //        return skaicius1;
        //    }
        //    else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
        //    {
        //        return skaicius2;
        //    }
        //    else
        //    {
        //        return skaicius3;
        //    }
        //}

        //***Užduotis 3

        //public static void Main3(string[] args)
        //{
        //    Console.WriteLine("Iveskite raide: ");
        //    string rezultatas = ArBalse(Console.ReadLine()?.ToLower());
        //    Console.WriteLine(rezultatas);
        //}
        //public static string ArBalse(string raide)
        //{
        //    if (raide == "a" || raide == "e" || raide == "i" || raide == "y" || raide == "o" || raide == "u")
        //    {
        //        return "Balse";
        //    }
        //    else
        //    {
        //        return "Priebalse";
        //    }
        //}

        //***Užduotis 4

        //public static void Main4(string[] args)
        //{
        //    Console.WriteLine("Iveskite metus: ");
        //    Console.WriteLine(ArKeliamieji(int.Parse(Console.ReadLine())));
        //    Console.WriteLine(ArKeliamieji);
        //}
        //public static string ArKeliamieji(int metai)
        //{
        //    if (metai % 4 == 0)
        //    {
        //        return "Keliamieji";
        //    }
        //    else
        //    {
        //        return "Nekeliamieji";
        //    }

        //}

        //***Užduotis 5

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite norima simboli: ");
        //    Console.WriteLine(ArSkaicius(Console.ReadLine()[0]));
        //    Console.WriteLine(ArSkaicius);
        //}
        //public static string ArSkaicius(char simbolis)
        //{
        //    if (char.IsDigit (simbolis))

        //        {
        //        return "skaicius";
        //    }
        //    else
        //    {
        //        return "raide";
        //    }

        //***Užduotis 6

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite valanda: ");
        //    int valanda = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Iveskite minutes: ");
        //    Console.WriteLine(ArLaikas(valanda, int.Parse(Console.ReadLine())));
        //    Console.WriteLine(ArLaikas);
        //}
        //public static string ArLaikas(int skaicius1, int skaicius2)
        //{
        //    if (skaicius1 > 0 && skaicius1 < 23 && skaicius2 > 0 && skaicius2 < 59)
        //    {
        //        return "Teisinga įvestis";
        //    }
        //    else
        //    {
        //        return "Neteisinga įvestis";
        //    }
        //}


        //***Užduotis 8
        ////

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite kvadrato krastine: ");
        //    double perimetras = Krastine(double.Parse(Console.ReadLine()));
        //    Console.WriteLine("Kvadrato perimetras: " + perimetras);
        //}
        //public static double Krastine(double skaicius)
        //{
        //    return skaicius * 4;
        //}

        //***Užduotis 9
        //

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite trikampio ilgi : ");
        //    double ilgis = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Iveskite trikampio auksti : ");
        //    double plotas = Krastines(ilgis, double.Parse(Console.ReadLine()));
        //    Console.WriteLine("Trikampio plotas: " + plotas);
        //}
        //public static double Krastines(double skaicius1, double skaicius2)
        //{
        //    return (skaicius1 * skaicius2) / 2;
        //}

        //***Užduotis 10
        //

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite apskritimo spinduli : ");
        //    double plotas = SkaiciuokPlota(double.Parse(Console.ReadLine()));
        //    double perimetras = SkaiciuokPerimetra(double.Parse(Console.ReadLine()));
        //    Console.WriteLine("Apskritimo plotas: " + plotas);
        //    Console.WriteLine("Apskritimo perimetras: " + perimetras);
        //}
        //public static double SkaiciuokPlota (double skaicius)
        //{
        //    return (Math.PI * (skaicius * skaicius));
        //}
        //public static double SkaiciuokPerimetra (double skaicius)
        //{
        //    return (2* Math.PI * skaicius);
        //}

        //***Užduotis 11
        //

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite kubo krastines ilgi : ");
        //    double turis = SkaiciuokTuri(double.Parse(Console.ReadLine()));
        //    Console.WriteLine("Kubo turis: " + turis);
        //}
        //public static double SkaiciuokTuri(double skaicius)
        //{
        //    return skaicius * skaicius * skaicius;
        //}

        //***Užduotis 12
        //

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Iveskite temperatura Celsijaus : ");
        //    double Farenheitas = SkaiciuokTemperatura(double.Parse(Console.ReadLine()));
        //    Console.WriteLine("Temperatura Farenheitu: " + Farenheitas);
        //}
        //public static double SkaiciuokTemperatura(double skaicius)
        //{
        //    return (skaicius * 1.8) + 32;
        //}


    }


}

