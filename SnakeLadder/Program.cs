using SnakeLadder;
using System;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.DieRoll();
            int player1 = operation.Game();
            Operation operation1 = new Operation();
            operation1.DieRoll();
            int player2 = operation1.Game();

            Console.WriteLine("Player1 played: " + player1 + " times " + "\nPlayer2 played: " + player2 + "times");

            if (player1.CompareTo(player2) > 0)
            {
                Console.WriteLine("Player 2");
            }
            else if (player1.CompareTo(player2) < 0)
            {
                Console.WriteLine("Player 1 ");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
