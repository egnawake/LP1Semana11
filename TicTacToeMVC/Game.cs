namespace TicTacToeMVC
{
    public class Game
    {
        public const int Size = 3;

        private Piece[,] board;

        public Game()
        {
            board = new Piece[Size, Size];
        }

        /// <summary>
        /// Get piece at given space.
        /// </summary>
        /// <param name="space">A number from 1 to 9.</param>
        public Piece PieceAt(int space)
        {
            int index = space - 1;
            return board[index / Game.Size, index % Game.Size];
        }

        /// <summary>
        /// Play a piece to the board.
        /// </summary>
        /// <returns>True if the play was valid, else false.</returns>
        public bool Play(Piece p, int space)
        {
            Piece piece = PieceAt(space);
            if (piece != Piece.Empty)
            {
                return false;
            }

            int index = space - 1;
            board[index / Game.Size, index % Game.Size] = p;

            return true;
        }

        /// <summary>
        /// Checks the current board for a victory state.
        /// </summary>
        /// <returns>The empty piece if nobody wins, otherwise the winner's piece.</returns>
        public Piece CheckVictory()
        {
            // Check rows
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                return board[0, 0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return board[2, 0];
            }

            // Check columns
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return board[0, 2];
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }

            return Piece.Empty;
        }
    }
}
