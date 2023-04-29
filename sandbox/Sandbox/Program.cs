using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
         string characterName = "John";
         int characterAge;
         characterAge = 35;
         

         Console.WriteLine("The once was a man named George " + characterName); //can concatenate
         Console.WriteLine($"He was " + characterName + " years old");

         characterName = "Mike"; //can change the name at anytime
         Console.WriteLine("He liked the name {characterName}"); //can use this easier version
         Console.WriteLine($"But he didn't like being {characterAge}");
         
         Console.ReadLine();
        }
    }
}