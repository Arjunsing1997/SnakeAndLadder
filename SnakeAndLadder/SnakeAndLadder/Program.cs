using System;

namespace SnakeAndLadder
{
    class Program
    {
        static int position = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SNAKE AND LADDER");
            DiceRoll();
        }

        public static void DiceRoll()  //UC2
        {
            Random random = new Random(); //Creating an object from Random class
            int diceValue = random.Next(1, 7); //Generating Random values from 1 to 6
            Console.WriteLine("Dice Value: " + diceValue);
        }
    }
}
