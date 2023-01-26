using System;
namespace Array_Methods;
class Program
{
    static void Main(string[] args)
    {
        //sort
        Console.WriteLine("***SirasizDizi***");
        int[] sayiDizisi={23,12,4,86,72,3,11,17};
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("***SiraliDizi***");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("***Clear***");
        Array.Clear(sayiDizisi,2,2);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //reverse
        Console.WriteLine("***ArrayReverse***");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //IndexOf
        Console.WriteLine("*** Array IndexOf ***");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));
        //Resize
        Console.WriteLine("*** Resize ***");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

    }
}
