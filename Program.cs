// See https://aka.ms/new-console-template for more information
using System;

namespace TextGame{

    class Program{

        public static void Main(string[] args){
            Console.WriteLine("Launching TextGame...");

            Gladiator player = new Gladiator("William", "Mage", 100, 100, 100);
            
            Console.WriteLine("Created " + player.Name + ", the " + player.CombatClass + "!");
            Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            Console.WriteLine(player.Name + " took 10 damage");
            player.HealthCurrent += -10;
            Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            
        }
    }
}
