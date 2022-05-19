using System;

namespace TicTacToeMVC
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Game game = new Game();

            IView consoleView = new ConsoleView();

            Controller controller = new Controller(game, consoleView);
            controller.Run();
        }
    }
}
