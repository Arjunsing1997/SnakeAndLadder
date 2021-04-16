using System;

namespace SnakeAndLadder
{
    public class Program
    {
        //static int position;
        const int Max_Position = 100;
        static int count = 0;
        static int option;
        const int ladder = 2;
        static int player1_Position = 0;
        static int player2_Position = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SNAKE AND LADDER");
            while (player1_Position < Max_Position && player2_Position < Max_Position)//to Execute until reach 100th Position
            {
                Player1();
                if(player1_Position < Max_Position)
                {
                    Player2();
                }
               
            }
            Console.WriteLine("\nNumber of games: " + count); //the number of games

        }

        public static int DiceRoll()  //UC2
        {
            Random random = new Random(); //Creating an object from Random class
            int diceValue = random.Next(1, 7); //Generating Random values from 1 to 6
            //Console.WriteLine("Dice Value: " + diceValue);
            return diceValue;
            //CheckOption(diceValue);
        }

        public static int CheckOption(int diceValue,int position)    //UC3
        {

            Random random = new Random();
            option = random.Next(1, 4);     //generating a random number from 1 to 3

            switch (option) //Using switch case to choose ladder and snake in the game
            {
                case 1:
                    Console.WriteLine("No Play!!!!");   //this case for NO PLAY
                   // Console.WriteLine("POSITION: " + position);
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Ladder..."); //this case is for LADDER
                    position = position + diceValue;
                    position = Position(diceValue, position);
                   // Console.WriteLine("POSITION: " + position);
                    count++;
                    break;
                case 3:
                    Console.WriteLine("Snake..."); //this case is for SNAKE
                    position = position - diceValue;
                    position = Position(diceValue, position);
                    //Console.WriteLine("POSITION: " + position);
                    count++;
                    break;
            }
            return position;
        }
        public static int Position(int  diceValue, int Position) //UC4
        {
            if (Position > 100)  //To check whether position Crossing the 100th line
            {
                Position = Position - diceValue; //if Position crosses the 100th posotion then we are making the position value as Previous 
            }
            else if (Position < 0)  //condition to check wheter position is lss than 0
            {
                Position = 0; //if position value is negative then we are assigning 0 to 
            }
            return Position;
        }

        public static void Player1()
        {
            int diceValue = DiceRoll();
            Console.WriteLine("Player1 Dice Value" + diceValue);
            player1_Position = CheckOption(diceValue,player1_Position);
            Console.WriteLine("Player1 Current Position: " + player1_Position);
            if (player1_Position == Max_Position)
            {
                Console.WriteLine("------PLAYER1 WIN-----");

            }
            else if(option == ladder)
            {
                Player1();
            }
        }
        public static void Player2()
        {
            int diceValue = DiceRoll();
            Console.WriteLine("Player2 Dice Value" + diceValue);
            player2_Position = CheckOption(diceValue,player2_Position);
            Console.WriteLine("Player2 Current Position: " + player2_Position);
            if (player2_Position == Max_Position)
            {
                Console.WriteLine("------PLAYER2 WIN-----");
            }
            else if (option == ladder)
            {
                Player2();
            }
        }
    }
}
