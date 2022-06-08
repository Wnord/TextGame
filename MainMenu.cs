using System;

namespace TextGame{

    public class MainMenu{

        public static void PrintMenu(){
            Console.WriteLine("---{Main Menu}---");
            Console.WriteLine("[1]");
            Console.WriteLine("[2]");
            Console.WriteLine("[3]");
            Console.WriteLine("[0] Exit\n");

            GetInput();
        }

        public static int GetInput(){

            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("");
            int convertedInput = (int) Char.GetNumericValue(input[0]);
            //Int32.TryParse(input[0], out convertedInput);
            int testAdd = convertedInput + convertedInput;

            Console.WriteLine(convertedInput);
            Console.WriteLine("Input added together test: " + testAdd);

            return convertedInput;
        }

    }

}