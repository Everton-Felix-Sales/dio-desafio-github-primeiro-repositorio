using DIO.Entities;
using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23,"Knight", 469/ 749, 72/ 72);
            Ninja ninja = new Ninja("Wedge", 42,"Ninja", 292/ 574, 89/ 89);
            WhiteWizard whitewizard = new WhiteWizard("Jenica", 42, "WhiteWizard", 325/ 601, 474/ 482);
            BlackWizard blackwizard = new BlackWizard("Wedge", 42, "BlackWizard", 106/ 385, 611/ 641);
           


            Console.WriteLine(arus.Attack(8));
            Console.WriteLine(ninja.Attack(16));
            Console.WriteLine(whitewizard.Attack(6));
            Console.WriteLine(blackwizard.Attack(21));
            
        }
    }
}
