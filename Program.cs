using System;

int playerPoints = 0;
int rivalPoints = 0;

Console.WriteLine("Dice Game");
Console.WriteLine();
Console.WriteLine("When playing this game, you will go against the computer for 10 rounds.");
Console.WriteLine("Every round the computer will roll the 6 sided die and then you will roll the die."); 
Console.WriteLine("Whoever rolls the highest number wins the round. Whoever was won more rounds wins the game.");
Console.WriteLine();
Console.WriteLine("Press any key to start the game...");
Console.ReadKey(true);
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Round {i + 1}");
    int rivalRandomNum = Random.Shared.Next(1,7);
    Console.WriteLine("Rival rolled a " + rivalRandomNum);
    Console.WriteLine("Press anykey to roll your dice.");
    Console.ReadKey(true);
    Console.WriteLine();
    int playerRandomNum = Random.Shared.Next(1,7);
    Console.WriteLine("You rolled a " + playerRandomNum);
    

    if(playerRandomNum > rivalRandomNum)
    {
        playerPoints++;
        Console.WriteLine("You won this round!");
    }

    else if (playerRandomNum < rivalRandomNum)
    {
        rivalPoints++;
        Console.WriteLine("Your opponent won this round.");
    }

    else 
    {
        Console.WriteLine("Draw!");
    }

    Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {rivalPoints} ");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey(true);
    Console.WriteLine();
    Console.WriteLine();

}

Console.WriteLine("GAME OVER");
Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {rivalPoints}");
if (playerPoints > rivalPoints)
{

    Console.WriteLine("You win!");

}

else if (playerPoints < rivalPoints)
{

    Console.WriteLine("You lost, good game.");

}

else
{

    Console.WriteLine("This whole game was a DRAW!");

}
Console.WriteLine("Press any key to quit");
Console.ReadKey(true);