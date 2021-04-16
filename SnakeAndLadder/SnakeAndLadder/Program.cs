using System;

namespace SnakeAndLadder
{
    public class Program
    {
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
                if(player1_Position < Max_Position) //To check whether player1 reaches to last position
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
            return diceValue; //Returning a value to the Particular method
        }

        public static int CheckOption(int diceValue,int position)    //UC3
        {

            Random random = new Random();
            option = random.Next(1, 4);     //generating a random number from 1 to 3

            switch (option) //Using switch case to choose ladder and snake in the game
            {
                case 1:
                    Console.WriteLine("No Play!!!!");   //this case for NO PLAY
                    count++;    //Increamenting Count value by 1 to count number of games
                    break;
                case 2:
                    Console.WriteLine("Ladder..."); //this case is for LADDER
                    position = position + diceValue;
                    position = Position(diceValue, position);
                    count++;
                    break;
                case 3:
                    Console.WriteLine("Snake..."); //this case is for SNAKE
                    position = position - diceValue;
                    position = Position(diceValue, position);
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

        public static void Player1()        //for Player1
        {
            int diceValue = DiceRoll();     //calling DiceRoll method to generate dice value
            Console.WriteLine("Player1 Dice Value" + diceValue);
            player1_Position = CheckOption(diceValue,player1_Position); //checking option for Snake ladder or No Play
            Console.WriteLine("Player1 Current Position: " + player1_Position);
            if (player1_Position == Max_Position) //if Player 1 position reaches to max position then players1 wins
            {
                Console.WriteLine("------PLAYER1 WIN-----");

            }
            else if(option == ladder) //if player gets ladder then he must play again
            {
                Player1(); //calling mathod to play again //it's Recursion method
            }
        }
        public static void Player2()
        {
            int diceValue = DiceRoll();     //calling DiceRoll method to generate dice value
            Console.WriteLine("Player2 Dice Value" + diceValue);
            player2_Position = CheckOption(diceValue,player2_Position);     //checking option for Snake ladder or No Play
            Console.WriteLine("Player2 Current Position: " + player2_Position);
            if (player2_Position == Max_Position)   //if Player 2 position reaches to max position then players1 wins
            {
                Console.WriteLine("------PLAYER2 WIN-----");
            }
            else if (option == ladder)//if player gets ladder then he must play again
            {
                Player2();//calling mathod to play again //it's Recursion method
            }
        }
    }
}
