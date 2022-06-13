// See https://aka.ms/new-console-template for more information
using System;

namespace TextGame{

    class Program{

        public static void Main(string[] args){
            Console.WriteLine("Launching TextGame...");

            int menuReturnValue;
            bool shouldExit = false;
            Gladiator playerGladiator = null;

            //Gladiator player = new Gladiator("William", "Mage", 100, 100, 100);
            
            //Console.WriteLine("Created " + player.Name + ", the " + player.CombatClass + "!");
            //Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            //Console.WriteLine(player.Name + " took 10 damage");
            //player.HealthCurrent += -10;
            //Console.WriteLine("Health: " + player.HealthCurrent + "/" + player.HealthMax);

            

            while(!shouldExit){

                menuReturnValue = MenuHandler.PrintMenu();

                switch(menuReturnValue){
                    case 1: Console.WriteLine("Program.cs received return value 1, should start new game...");
                            if(playerGladiator == null){
                                playerGladiator = MenuHandler.NewGameMenu();
                            }
                            if(playerGladiator != null){
                                GladiatorTestPrint(playerGladiator);
                            }
                            //shouldExit = true;
                            break;
                    case 2: Console.WriteLine("Program.cs received return value 2, should load game..."); break;
                    case 3: Console.WriteLine("Program.cs received return value 3, should open settings..."); break;
                    case 0: Console.WriteLine("Program.cs received return value 0, should exit game..."); shouldExit = true; break;
                    default: Console.WriteLine("[ERROR/Program.cs] Program.cs received invalid return value: " + menuReturnValue); break;
                }
            }
            


        }

        public static void GladiatorTestPrint(Gladiator glad){
            Console.WriteLine("---[Gladiator Test Print]---");
            Console.WriteLine("Gladiator name: " + glad.Name);
            Console.WriteLine("Gladiator class: " + glad.CombatClass);
            Console.WriteLine("Gladiator health: " + glad.HealthCurrent + "/" + glad.HealthMax);
            Console.WriteLine("Gladiator stamina: " + glad.StaminaCurrent + "/" + glad.StaminaMax);
            Console.WriteLine("Gladiator mana: " + glad.ManaCurrent + "/" + glad.ManaMax);
        }
    }
}
