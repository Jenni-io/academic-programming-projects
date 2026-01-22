/* 
----------------------------------------------------------------
<Program Title> Monty Hall problem 
----------------------------------------------------------------
Developer:     Jenni Morales Jeronimo
Creation date: 4/27/2025
Last modified: 5/2/2025
Email address: jamoralesjeronimo@senators.ws.edu
-----------------------------------------------------------------
Purpose: The program proves the "Monty Hall Problem" by simulating  a
million "games" for each strategy.
-----------------------------------------------------------------
*/

public class MontyHallTest
{
     static void Main()
    {
    
        // States what program does
        Console.WriteLine("Demonstrating the \"Monty Hall Hall Problem\"\n");
        Console.WriteLine("Simulating 1,000,000 games for each strategy. \n");

        // sets strategy to switch
        GameStrategy strategy = GameStrategy.Switch;
        simulate("SWITCH Strategy ", strategy); // passes the "name" and strategy to the simulate method

        // sets strategy to Keep
        strategy = GameStrategy.Keep;
        simulate("KEEP Strategy", strategy);

        // sets strategy to Random
        strategy = GameStrategy.Random;
        simulate("RANDOM Strategy", strategy);

    }

    static void simulate(string name, GameStrategy strategy)
    {
        int totalGames = 1_000_000; // set num of times this will loop
        int wins = 0; // counts wins

        for (int i = 0; i < totalGames; i++) // loops 1,000,000
        {
            // creates a new instance of Monty Hall game
            LetsMakeADeal MontyGame = new LetsMakeADeal();

            // plays one round of simulated game using selected strategy 
            GameResult result = MontyGame.PlayGame(strategy);

            // if player won count the won amount
            if (result == GameResult.Won)
                wins++;
        }
        // calulates losses
        int losses = totalGames - wins;

        // creates total data aquited to percents
        double winsPercent = wins / (double)totalGames * 100;
        double lossPercent = losses / (double)totalGames * 100;

        // outputs data results
        Console.WriteLine($"{name}\n");
        Console.WriteLine($"Wins:\t{wins:N0} ({winsPercent:F2}%)");
        Console.WriteLine($"Losses:\t{losses:N0} ({lossPercent:F2}%)\n");
    }
}