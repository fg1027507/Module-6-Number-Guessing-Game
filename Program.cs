/*
Number Guessing Game
Made by Finn Gilbert
Created on September 25, 2025
*/
using System;
int gameMode = 0;
int rangeLow = 1;
int rangeHigh = 10;
int guess = 0;
int score = 0;
var playing = "yes";
bool keepPlaying = true;

while (keepPlaying == true)
{
    // Sets the random numbers needed
    Random rand = new Random();
    // Asks the user which game mode is wanted
    Console.WriteLine("How hard do you want this game? Their is easy (ranges from 1 to 10), medium (ranges from 1 to 50), and hard (ranges from 1 to 100)!");
    Console.WriteLine("please type easy, medium or hard any way you want!");
    Console.Write(">> ");
    string ans = Console.ReadLine().ToUpper();
    // sets the game mode based on what the user wanted
    switch (ans)
    {
        case "EASY":
            //Set easy mode variable to a random number between (1 - 10)
            rangeLow = 1;
            rangeHigh = 10;
            break;
        case "MEDIUM":
            //Set medium mode variable to a random number between (1 - 50)
            rangeLow = 1;
            rangeHigh = 50;
            break;
        case "HARD":
            //Set hard mode variable to a random number between (1 - 100)
            rangeLow = 1;
            rangeHigh = 100;
            break;
        default:
            //Makes sure that the user can contine no matter what
            Console.WriteLine("Invalid choice. Defaulting to easy mode");
            rangeLow = 1;
            rangeHigh = 10;
            break;
    }
    gameMode = rand.Next(rangeLow, rangeHigh + 1);
    Console.WriteLine(gameMode);
    // Wishes the user luck in guessing
    Console.WriteLine($"You picked {ans} MODE and that ranged from {rangeLow} to {rangeHigh}! Good luck!");
    score = 0;
    do
    {
        //Ask the user to guess a number between the set range
        Console.WriteLine();
        Console.WriteLine("What number do you guess!?");
        Console.Write(">> ");
        guess = Convert.ToInt32(Console.ReadLine());
        //If the guessed number is higher then the random number tell the user that the guess number is higher that the random number
        if (guess > gameMode)
        {
            Console.WriteLine("Your number is greater than the random number");
            Console.WriteLine("Try again");
            score++;
        }
        //If the guessed number is lower then the random number tell the user that the guess number is lower that the random number
        else if (guess < gameMode)
        {
            Console.WriteLine("Your number is less than the random number");
            Console.WriteLine("Try again");
            score++;
        }
        //If the guessed number is equal to the random number tell the user that the guessed number is equal to the random number
        else if (guess == gameMode)
        {
            score++;
            Console.WriteLine("You guessed correctly! You won the game!");
            Console.WriteLine($"It took you {score} tries to guess the number on {ans} MODE!");
            Console.WriteLine("Do you want to keep playing? (yes or no)");
            Console.Write(">> ");
            playing = Console.ReadLine().ToLower();
            //Ask the user if they want to keep playing
            if (playing == "no")
            {
                //If no tell the user “Thank you for playing
                Console.WriteLine("Thank you for playing!");
                keepPlaying = false;
                break;
            }
        }
    } while (guess != gameMode);
}
