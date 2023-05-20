using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(1);
        Fraction fraction2 = new Fraction(3, 4);
        
        Console.WriteLine($"{fraction.GetFractionString()} {fraction.GetDecimalValue()}");
        Console.WriteLine($"{fraction1.GetFractionString()} {fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetFractionString()} {fraction2.GetDecimalValue()}");
        
    }
}