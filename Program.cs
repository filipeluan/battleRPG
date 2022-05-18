using  System;
using static System.Console;
using Jogo_RPG___POO.src.Entities;

namespace Jogo_RPG___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Arus", 45, "Knight");
            Wizard wizard = new Wizard("Jenica", 35, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 40, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 32, "Black Wizard");
            
            Battle battle = new Battle(warrior, ninja);
            battle.InicializationBattle();

        }

    }
}