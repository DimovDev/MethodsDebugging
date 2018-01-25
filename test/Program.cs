using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStartingMessage();
            GetPlayerNames();
            RunMoveLoop();
            System.Threading.Thread.Sleep(-1); // Freezes on the end screen to show the result of the game
        }

        // Prints the current game board state
        static void PrintGameBoard()
        {
            Console.WriteLine("{0} {1} {2}", Data.a3, Data.b3, Data.c3);
            Console.WriteLine("{0} {1} {2}", Data.a2, Data.b2, Data.c2);
            Console.WriteLine("{0} {1} {2}", Data.a1, Data.b1, Data.c1);
        }

        // Takes inputs until a valid move is written, then saves it to Data
        static void MakeMove(string currentPlayer)
        {
            bool invalidMove = true;
            while (invalidMove)
            {
                string currentMove = Console.ReadLine();
                char currentPlayerChar;
                if (currentPlayer == "playerOne") currentPlayerChar = 'x';
                else currentPlayerChar = 'o';
                if (currentMove == "a1" && Data.a1 == '.') { Data.a1 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "a2" && Data.a2 == '.') { Data.a2 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "a3" && Data.a3 == '.') { Data.a3 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "b1" && Data.b1 == '.') { Data.b1 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "b2" && Data.b2 == '.') { Data.b2 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "b3" && Data.b3 == '.') { Data.b3 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "c1" && Data.c1 == '.') { Data.c1 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "c2" && Data.c2 == '.') { Data.c2 = currentPlayerChar; invalidMove = false; }
                else if (currentMove == "c3" && Data.c3 == '.') { Data.c3 = currentPlayerChar; invalidMove = false; }
                else Console.WriteLine("That is not a valid move! Try again:");
            }
        }

        // Checks if there is a winner, prints the win message and returns the result as a boolean
        static bool ThereIsAWinner()
        {
            if (
                        (Data.a1 == 'x' && Data.a2 == 'x' && Data.a3 == 'x') ||
                        (Data.b1 == 'x' && Data.b2 == 'x' && Data.b3 == 'x') ||
                        (Data.c1 == 'x' && Data.c2 == 'x' && Data.c3 == 'x') ||
                        (Data.a1 == 'x' && Data.b1 == 'x' && Data.c1 == 'x') ||
                        (Data.a2 == 'x' && Data.b2 == 'x' && Data.c2 == 'x') ||
                        (Data.a3 == 'x' && Data.b3 == 'x' && Data.c3 == 'x') ||
                        (Data.a1 == 'x' && Data.b2 == 'x' && Data.c3 == 'x') ||
                        (Data.a3 == 'x' && Data.b2 == 'x' && Data.c1 == 'x')
                        ) { Console.WriteLine($"Congratulations, {Data.playerOneName}! You Won!"); return true; }
            else if (
                            (Data.a1 == 'o' && Data.a2 == 'o' && Data.a3 == 'o') ||
                            (Data.b1 == 'o' && Data.b2 == 'o' && Data.b3 == 'o') ||
                            (Data.c1 == 'o' && Data.c2 == 'o' && Data.c3 == 'o') ||
                            (Data.a1 == 'o' && Data.b1 == 'o' && Data.c1 == 'o') ||
                            (Data.a2 == 'o' && Data.b2 == 'o' && Data.c2 == 'o') ||
                            (Data.a3 == 'o' && Data.b3 == 'o' && Data.c3 == 'o') ||
                            (Data.a1 == 'o' && Data.b2 == 'o' && Data.c3 == 'o') ||
                            (Data.a3 == 'o' && Data.b2 == 'o' && Data.c1 == 'o')
                            ) { Console.WriteLine($"Congratulations, {Data.playerTwoName}! You Won!"); return true; }
            else return false;
        }

        // Explains the way the game works
        static void PrintStartingMessage()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe Version Alpha 1.0");
            Console.WriteLine("Created by Petar Peychev, 2017");
            Console.WriteLine("This is the game board:");
            PrintGameBoard();
            Console.WriteLine("The points on the board are indexed as such:");
            Console.WriteLine("a3 b3 c3");
            Console.WriteLine("a2 b2 c2");
            Console.WriteLine("a1 b1 c1");
            Console.WriteLine("The two players alternate by typing in coordinates for their moves.");
        }

        // Asks players for their names and saves them to Data
        static void GetPlayerNames()
        {
            Console.WriteLine("Player 1, what is your name?");
            Data.playerOneName = Console.ReadLine();
            Console.WriteLine("And what do you go by, Player 2?");
            Data.playerTwoName = Console.ReadLine();
        }

        // Checks if the game is a draw, prints the draw message and returns the result as a boolean
        static bool GameIsADraw()
        {
            if (Data.turnCounter == 9)
            {
                Console.WriteLine("Game is a draw!");
                return true;
            }
            else return false;
        }

        // Alternates making moves between the players and clearing, then printing the board until there is a winner or a draw is reached
        static void RunMoveLoop()
        {
            string currentPlayer = "playerOne";
            while (true)
            {
                Data.turnCounter++;
                if (currentPlayer == "playerOne") Console.WriteLine($"It's your move, {Data.playerOneName}:");
                else Console.WriteLine($"It's your move, {Data.playerTwoName}:");
                MakeMove(currentPlayer);
                currentPlayer = currentPlayer == "playerOne" ? "playerTwo" : "playerOne";
                Console.Clear();
                PrintGameBoard();
                if (ThereIsAWinner() || GameIsADraw()) break;
            }
        }
    }

    // Stores all relevant global data - the game board, player names and turn counter
    class Data
    {
        public static char a1 = '.';
        public static char a2 = '.';
        public static char a3 = '.';
        public static char b1 = '.';
        public static char b2 = '.';
        public static char b3 = '.';
        public static char c1 = '.';
        public static char c2 = '.';
        public static char c3 = '.';
        public static string playerOneName;
        public static string playerTwoName;
        public static byte turnCounter = 0;
    }
}
        
    


