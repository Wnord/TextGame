// See https://aka.ms/new-console-template for more information
using System;

namespace TextGame{

    class Program{

        public static void Main(string[] args){
            Console.WriteLine("Launching TextGame...");

            Gladiator player = new Gladiator("William", "Mage", 100, 100, 100);
            
            //Console.WriteLine("Created " + player.Name + ", the " + player.CombatClass + "!");
            //Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            //Console.WriteLine(player.Name + " took 10 damage");
            //player.HealthCurrent += -10;
            //Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            int menuReturnValue;
            menuReturnValue = MenuHandler.PrintMenu();
            
            switch(menuReturnValue){
                case 1: Console.WriteLine("Program.cs received return value 1, should start new game..."); break;
                case 2: Console.WriteLine("Program.cs received return value 2, should load game..."); break;
                case 3: Console.WriteLine("Program.cs received return value 3, should open settings..."); break;
                case 0: Console.WriteLine("Program.cs received return value 0, should exit game..."); break;
                default: Console.WriteLine("[ERROR/Program.cs] Program.cs received invalid return value: " + menuReturnValue); break;
            }
        }
    }
}
