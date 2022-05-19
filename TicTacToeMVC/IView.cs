namespace TicTacToeMVC
{
    public interface IView
    {
        public void ShowBoard(Game game);

        public int PromptSpace(Piece player);

        public void AnnounceVictory(Piece winner);

        public void WarnInvalidPlay(int space);
    }
}
