namespace TicTacToe_Game
{
    internal class Program
    {
        // შევქმენი სათამაშოდ საჭირო ცვლადები
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';
        static bool isGameOver = false;
        static int movesCount = 0;

        static void Main(string[] args)
        {
            InitializeBoard();
            while (!isGameOver)
            {
                Console.Clear();
                DrawBoard();

                int row = -1, col = -1;
                while (!GetMove(ref row, ref col)) { }

                board[row, col] = currentPlayer;
                movesCount++;

                if (CheckWin())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    isGameOver = true;
                }
                else if (movesCount == 9)
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("It's a draw!");
                    isGameOver = true;
                }

                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }

        // ვაინიციალიზირებ სათამაშო მაგიდას
        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' '; // თითოეული უჯრა ცარიელია
                }
            }
        }

        // სათამაშო მაგიდის დახატვა
        static void DrawBoard()
        {
            Console.WriteLine("   0   1   2 ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  -------------");
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("| " + board[i, j] + " ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("  -------------");
        }

        // მოთამაშის სვლის მიღება
        static bool GetMove(ref int row, ref int col)
        {
            Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");

            bool isValidInput = int.TryParse(Console.ReadLine(), out row) && int.TryParse(Console.ReadLine(), out col);

            if (isValidInput && row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
            {
                return true;
            }

            Console.WriteLine("Invalid move, try again.");
            return false;
        }

        // გამარჯვების შემოწმება
        static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;

            for (int i = 0; i < 3; i++)
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;

            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;

            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }
    }
}
