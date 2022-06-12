using System;

namespace TextGame{

    public class MenuHandler{

        public static int PrintMenu(){
            int choice = -1;
            int returnValue = -1;

            while(returnValue == -1){
                Console.WriteLine("---{Main Menu}---");
                Console.WriteLine("[1] New Game");
                Console.WriteLine("[2] Load Game");
                Console.WriteLine("[3] Settings");
                Console.WriteLine("[0] Exit\n");

                choice = GetInput();

                switch(choice){
                    case 1: Console.WriteLine("Choice 1 will start new game..."); returnValue = 1; break;
                    case 2: Console.WriteLine("Choice 2 will load existing game..."); returnValue = 2; break;
                    case 3: Console.WriteLine("Choice 3 will open settings menu..."); returnValue = 3; break;
                    case 0: Console.WriteLine("Choice 0: Exiting game..."); returnValue = 0; break;
                    default: Console.WriteLine("[ERROR/MenuHandler.cs] PrintMenu: Switch defaulted."); returnValue = -1; break;
                }
            }

            return returnValue;

        }

        public static int GetInput(){
            string input = "";

            Console.Write("Input: ");
            try{
                input = Console.ReadLine();
            } catch(IOException e){
                Console.WriteLine("Input IOException");
            };
            
            Console.WriteLine("");
            if(String.IsNullOrEmpty(input)){

            }
            int convertedInput = (int) Char.GetNumericValue(input[0]);
            //Int32.TryParse(input[0], out convertedInput);
            //int testAdd = convertedInput + convertedInput;

            //Console.WriteLine(convertedInput);
            //Console.WriteLine("Input added together test: " + testAdd);

            return convertedInput;
        }

        public static Gladiator NewGameMenu(){
            int newGameReturnValue = -1;
            int menuChoice = -1;
            bool classChosen = false;

            string gName = "";
            string gClass = "def";

            //Menu for starting new game (create char)

            while(!classChosen){
                Console.WriteLine("\nChoose a class for your gladiator:");
                Console.WriteLine("[1] Warrior");
                Console.WriteLine("[2] Mage");
                Console.WriteLine("[3] Rogue\n");

                switch(menuChoice = GetInput()){
                    case 1: gClass = "Warrior"; classChosen = true; break;
                    case 2: gClass = "Mage"; classChosen = true; break;
                    case 3: gClass = "Rogue"; classChosen = true; break;
                    default: Console.WriteLine("[ERROR/MenuHandler.cs/NewGameMenu] Switch defaulted, try again."); break;
                }
            }

            while(String.IsNullOrEmpty(gName)){
                Console.WriteLine("What should your gladiator be named?");
                Console.Write("Name: ");
                gName = Console.ReadLine();
            }

            Gladiator newGladiator = new Gladiator(gName, gClass);

            return newGladiator;
        }

    }

}