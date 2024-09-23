using System;

class Program
{
    static void Main()
    {
        // Fråga användaren om det första talet
        Console.Write("Ange det första talet: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        // Fråga användaren om det andra talet
        Console.Write("Ange det andra talet: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        // Addera talen
        double summa = tal1 + tal2;

        // Skriv ut resultatet
        Console.WriteLine("Summan av de två talen är: " + summa);
    }
}