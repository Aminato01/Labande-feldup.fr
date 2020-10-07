using System;

namespace ExerciseOne
{
    internal class Program
    {
        private static bool Error = false;

        /// <summary>
        /// Write your code in this method
        /// </summary>
        /// <param name="input"></param>
        public static void YourMethod(string input)
        {


            if (input.Length > 5){              //On vérifie la longueur de l'input, si il est supérieur à 5 alors on applique la condition
            input = input.Substring(0, 5);      //On applique la méthode "SubstringOf" à l'input, la première valeur indique ou l'on commence la lecture et la seconde valeur indique la longeur de la chaine de charactère que l'on veut après avoir placé l'index (première valeur)
            }





            Validation(input);



        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Write an algorithm that takes the 5 first characters of any string");
            Console.WriteLine("If the string has less than 5 chars, keep everything");
            Console.WriteLine("An empty space is considered as a char");
            Console.WriteLine("E.G:");
            Console.WriteLine("Input string: Amazon");
            Console.WriteLine("Result: Amazo");
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

            string input = "HelloWorld, this is an example";
            string input2 = "EDUZ_KZNDZAI_DKZLA?AZK";
            string input3 = "HEY,HA,OH,UH,IH";
            string input4 = "HEY";

            YourMethod(input);
            YourMethod(input2);
            YourMethod(input3);
            YourMethod(input4);

            Console.WriteLine("Press any key to close");
            if (Error)
            {
                Console.WriteLine("Your program has at least one error! Press any key to close.");
            }
            else
            {
                Console.WriteLine("Congratulations, you might be able to raise a PR for your code! Press any key to close.");
            }

            Console.ReadKey();
        }

        #region Validation

        public static void Validation(string input)
        {
            if (input.Length <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your input '{input}' is correct");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Error = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your input '{input}' has more than 5 chars");
                Console.ForegroundColor = ConsoleColor.White;
            }
           
        }

        #endregion Validation
    }
}