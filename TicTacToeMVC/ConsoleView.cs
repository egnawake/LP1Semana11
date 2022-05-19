using System;

namespace TicTacToeMVC
{
    public class ConsoleView : IView
    {
        public void ShowBoard(Game game)
        {
            Console.WriteLine("+---+---+---+");
            for (int i = 0; i < Game.Size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Game.Size; j++)
                {
                    Piece p = game.PieceAt((i * Game.Size + j) + 1);
                    if (p == Piece.Empty)
                    {
                        Console.Write("   ");
                    }
                    else if (p == Piece.O)
                    {
                        Console.Write(" O ");
                    }
                    else if (p == Piece.X)
                    {
                        Console.Write(" X ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
                Console.WriteLine("+---+---+---+");
            }
        }

        public int PromptSpace(Piece player)
        {
            Console.WriteLine($"{player} is playing...");
            Console.Write("> ");
            return int.Parse(Console.ReadLine());
        }

        public void AnnounceVictory(Piece player)
        {
            Console.WriteLine($"{player} wins!");
        }

        public void WarnInvalidPlay(int space)
        {
            Console.WriteLine($"Invalid play to space {space}!");
        }
    }
}
