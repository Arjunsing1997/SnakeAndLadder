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
            CheckOption(diceValue);
        }

        public static void CheckOption(int diceValue)    //UC3
        {

            Random random = new Random();
            int option = random.Next(1, 4);     //generating a random number from 1 to 3

            switch (option) //Using switch case to choose ladder and snake in the game
            {
                case 1:
                    Console.WriteLine("No Play!!!!");   //this case for NO PLAY
                    Console.WriteLine("POSITION: " + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder..."); //this case is for LADDER
                    position = position + diceValue;
                    Console.WriteLine("POSITION: " + position);
                    break;
                case 3:
                    Console.WriteLine("Snake..."); //this case is for SNAKE
                    position = position - diceValue;
                    Position();
                    Console.WriteLine("POSITION: " + position);
                    break;
            }
        }
        public static void Position() //UC4
        {
            if (position < 0)  //condition to check wheter position is lss than 0
            {
                position = 0; //if position value is negative then we are assigning 0 to 
            }
        }
    }
}
