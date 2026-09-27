using System;

public class GuessingGame {
    private static Random rand = new Random();
    public static void Main(string[] args) {
        int targetNumber = rand.Next(1, 101); 
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a secret number between 1 and 100.");
        Console.WriteLine("Try to guess it! The algorithm will tell you if you are too high or low.\n");
        int attempts = 0;
        bool hasWon = false;
        while (!hasWon) {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userGuess)) {
                attempts++;
                hasWon = CheckGuess(userGuess, targetNumber);
            } 
            else {
                Console.WriteLine("Kuch bhe! Please enter a valid number.");
            }
            Console.WriteLine("----------------------------------");
        }

        Console.WriteLine($"Awesome job! You found it in {attempts} attempts.");
    }

    public static bool CheckGuess(int guess, int target) {
        if (guess == target) {
            Console.WriteLine("Success! You guessed the correct number!");
            return true; 
        } 
        else if (guess < target) {
            Console.WriteLine("Your guessed number is low!");
            return false;
        } 
        else {
            Console.WriteLine("Your guessed number is high!");
            return false;
        }
    }
}
