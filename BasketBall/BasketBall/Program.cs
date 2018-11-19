using System;

namespace BasketBall
{
    class Program
    {
        //Set variables (can be done so at program start)
        //Not currently used
        int numStart = 0;
        int numEnd = 200;
        int checkOne = 3;
        int checkTwo = 7;
        string outputOne = "Basket";
        string outputTwo = "Ball";

        static void Main(string[] args)
        {
            //For each number between 1 and 200, not using variables at present
            for (int i = 1; i <= 200; i++)
            {
                string result = "";
                if (i % 3 == 0) { result += "Basket"; }
                if (i % 7 == 0) { result += "Ball"; }
                if (result == "") { result = Convert.ToString(i); }
                Console.WriteLine(result);
            }
            Console.WriteLine("Press ESC to exit"); // Wait for ESC keypress
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            { }//Exit app, nothing ran in while so app continues to end and exits
        }
    }
}
