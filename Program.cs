TicTacToe newGame = new TicTacToe();
int turn = 0;

Console.WriteLine("This is the layour for the board.  To play your symbol, simply type the word in of the box you'd like to play.");
Console.WriteLine("Example:  typing in \"one\" will play your symbol in that same spot of the grid.\n\n");
Console.WriteLine($"1 | 2 | 3");
Console.WriteLine("--+---+--");
Console.WriteLine($"4 | 5 | 6");
Console.WriteLine("--+---+--");
Console.WriteLine($"7 | 8 | 9\n\n");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("The game begins!");

while (true)
{
    newGame.BoardDisplay();

    newGame.PlayerOneTurn();
    newGame.CheckPlayerOneWinner();
    if (newGame.PlayerOneWin != 0)
    {
        break;
    }

    turn++;

    if (turn >= 9)
    {
        Console.WriteLine("Nobody has won - it's a draw!");
        break;
    }

    newGame.BoardDisplay();

    newGame.PlayerTwoTurn();
    newGame.CheckPlayerTwoWinner();
    if (newGame.PlayerTwoWin != 0)
    {
        newGame.BoardDisplay();
        break;
    }

    turn++;
}


public class TicTacToe
{
    private string GridSpotsOne = " ";
    private string GridSpotsTwo = " ";
    private string GridSpotsThree = " ";
    private string GridSpotsFour = " ";
    private string GridSpotsFive = " ";
    private string GridSpotsSix = " ";
    private string GridSpotsSeven = " ";
    private string GridSpotsEight = " ";
    private string GridSpotsNine = " ";
    string[,] grid = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

    public int PlayerOneWin { get; set; }
    public int PlayerTwoWin { get; set; }


    public TicTacToe()
    {

    }

    public void PlayerOneTurn()
    {
        Console.WriteLine("\nPlayer 1, it is your turn.  Choose a spot to place an X: ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "one" && GridSpotsOne == " ") GridSpotsOne = "X";
        if (userInput == "two" && GridSpotsTwo == " ") GridSpotsTwo = "X";
        if (userInput == "three" && GridSpotsThree == " ") GridSpotsThree = "X";
        if (userInput == "four" && GridSpotsFour == " ") GridSpotsFour = "X";
        if (userInput == "five" && GridSpotsFive == " ") GridSpotsFive = "X";
        if (userInput == "six" && GridSpotsSix == " ") GridSpotsSix = "X";
        if (userInput == "seven" && GridSpotsSeven == " ") GridSpotsSeven = "X";
        if (userInput == "eight" && GridSpotsEight == " ") GridSpotsEight = "X";
        if (userInput == "nine" && GridSpotsNine == " ") GridSpotsNine = "X";


        Console.WriteLine("\n-------------------------------------------------\n");

    }

    public void PlayerTwoTurn()
    {
        Console.WriteLine("\nPlayer 2, it is your turn.  Choose a spot to place an O: ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "one" && GridSpotsOne == " ") GridSpotsOne = "O";
        if (userInput == "two" && GridSpotsTwo == " ") GridSpotsTwo = "O";
        if (userInput == "three" && GridSpotsThree == " ") GridSpotsThree = "O";
        if (userInput == "four" && GridSpotsFour == " ") GridSpotsFour = "O";
        if (userInput == "five" && GridSpotsFive == " ") GridSpotsFive = "O";
        if (userInput == "six" && GridSpotsSix == " ") GridSpotsSix = "O";
        if (userInput == "seven" && GridSpotsSeven == " ") GridSpotsSeven = "O";
        if (userInput == "eight" && GridSpotsEight == " ") GridSpotsEight = "O";
        if (userInput == "nine" && GridSpotsNine == " ") GridSpotsNine = "O";

        Console.WriteLine("\n-------------------------------------------------\n");

    }

    public void BoardDisplay()
    {
        Console.WriteLine($"{GridSpotsOne} | {GridSpotsTwo} | {GridSpotsThree}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{GridSpotsFour} | {GridSpotsFive} | {GridSpotsSix}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{GridSpotsSeven} | {GridSpotsEight} | {GridSpotsNine}");
    }

    public void CheckPlayerOneWinner()
    {
        if (GridSpotsOne == "X" && GridSpotsTwo == "X" && GridSpotsThree == "X" || GridSpotsFour == "X" && GridSpotsFive == "X" && GridSpotsSix == "X"
            || GridSpotsSeven == "X" && GridSpotsEight == "X" && GridSpotsNine == "X" || GridSpotsOne == "X" && GridSpotsFour == "X" && GridSpotsSeven == "X"
            || GridSpotsTwo == "X" && GridSpotsFive == "X" && GridSpotsEight == "X" || GridSpotsThree == "X" && GridSpotsSix == "X" && GridSpotsNine == "X"
            || GridSpotsOne == "X" && GridSpotsFive == "X" && GridSpotsNine == "X" || GridSpotsThree == "X" && GridSpotsFive == "X" && GridSpotsSeven == "X")
        {
            Console.WriteLine("\nPlayer one has won!");
            PlayerOneWin++;
        }
    }

    public void CheckPlayerTwoWinner()
    {
        if (GridSpotsOne == "O" && GridSpotsTwo == "O" && GridSpotsThree == "O" || GridSpotsFour == "O" && GridSpotsFive == "O" && GridSpotsSix == "O"
            || GridSpotsSeven == "O" && GridSpotsEight == "O" && GridSpotsNine == "O" || GridSpotsOne == "O" && GridSpotsFour == "O" && GridSpotsSeven == "O"
            || GridSpotsTwo == "O" && GridSpotsFive == "O" && GridSpotsEight == "O" || GridSpotsThree == "O" && GridSpotsSix == "O" && GridSpotsNine == "O"
            || GridSpotsOne == "O" && GridSpotsFive == "O" && GridSpotsNine == "O" || GridSpotsThree == "O" && GridSpotsFive == "O" && GridSpotsSeven == "O")
        {
            Console.WriteLine("\nPlayer two has won!");
            PlayerTwoWin++;
        }
    }
}




// Signed By: Alex ;)