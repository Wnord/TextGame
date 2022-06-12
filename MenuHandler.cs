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
                    default: Console.WriteLine("Switch defaulted."); returnValue = -1; break;
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

        public static int NewGameMenu(){
            int newGameReturnValue = -1;

            //Menu for starting new game (create char)

            return newGameReturnValue;
        }

    }

}