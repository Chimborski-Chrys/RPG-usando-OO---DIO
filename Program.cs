using System;
using Jogo_RPG.src.Entities;

namespace Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knigth", 700, 90);
            Ninja ninja = new Ninja("Wedge", 29, "Ninja", 950, 300);
            Wizard wizard = new Wizard("Jennica", 50, "White wizard", 1400, 2000);
            BlackWizard blackWizard = new BlackWizard ("Topapa", 45, "Black wizard", 1200, 1900);


            Console.WriteLine(hero);
            Console.WriteLine(ninja);
            Console.WriteLine(blackWizard);            
             Console.WriteLine(wizard);
           

        }
    }
}
