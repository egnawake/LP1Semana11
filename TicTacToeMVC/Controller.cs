namespace TicTacToeMVC
{
    public class Controller
    {
        private IView view;
        private Game game;
        private Piece playing = Piece.O;

        public Controller(Game game, IView view)
        {
            this.view = view;
            this.game = game;
        }

        public void Run()
        {
            while (true)
            {
                int space = view.PromptSpace(playing);
                bool play = game.Play(playing, space);
                view.ShowBoard(game);

                if (!play)
                {
                    view.WarnInvalidPlay(space);
                }
                
                Piece winner = game.CheckVictory();
                if (winner != Piece.Empty)
                {
                    view.AnnounceVictory(winner);
                    break;
                }

                if (playing == Piece.O)
                {
                    playing = Piece.X;
                }
                else
                {
                    playing = Piece.O;
                }
            }
        }
    }
}
