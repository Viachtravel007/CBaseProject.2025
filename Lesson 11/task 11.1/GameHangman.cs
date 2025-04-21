using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject.Lesson_11.task_11._1
{
    class GameHangman
    {
        public static void Executor()
        {
            bool playAgain = true;
            while (playAgain)
            {
                string secretWord = GetRandomWord();
                char[] guessedLetters = new string('_', secretWord.Length).ToCharArray();
                int attempts = 6;
                Console.WriteLine($"The word contains {secretWord.Length} letters");

                do
                {
                    Console.WriteLine($"You have {attempts} attempts");
                    Console.Write($"Word: {PrintWord(guessedLetters)}");

                    Console.WriteLine();
                    Console.Write("Enter letter: ");
                    string input = Console.ReadLine()?.ToLower();

                    if (IsNotValidGuess(input) || AlreadyHave(guessedLetters, input))
                    {
                        Console.WriteLine("Input exactly one, already untaken, letter");
                        continue;
                    }

                    char guess = input[0];
                    PlayerGuess(guess, secretWord, ref guessedLetters, ref attempts);

                } while (attempts > 0 && guessedLetters.Contains('_'));

                GameResult(guessedLetters, secretWord);

                Console.WriteLine("One more try? (yes or no)");
                string answer = Console.ReadLine()?.ToLower();
                playAgain = answer == "yes";
            }
        }

        private static bool AlreadyHave(char[] guessedLetters, string input)
        {
            char letter = input[0];
            return guessedLetters.Contains(letter);
        }

        private static string GetRandomWord()
        {
            Random random = new Random();
            string[] wordList = { "plant", "ghost", "apple", "shark", "technology" };
            return wordList[random.Next(wordList.Length)];
        }

        private static bool IsNotValidGuess(string input)
        {
            return string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]);
        }

        private static void PlayerGuess(char guess, string secretWord, ref char[] guessedLetters, ref int attempts)
        {
            if (secretWord.Contains(guess))
            {
                for (int i = 0; i < guessedLetters.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedLetters[i] = guess;
                    }
                }
                Console.WriteLine("Correct!");
            }
            else
            {
                attempts--;
                Console.WriteLine("Incorrect");
            }
        }

        private static void GameResult(char[] guessedLetters, string secretWord)
        {
            if (!guessedLetters.Contains('_'))
            {
                Console.WriteLine($"Word \"{secretWord}\" guessed");
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
                Console.WriteLine($"You didn't guess the word \"{secretWord}\"");
            }
        }

        private static string PrintWord(char[] guessedLetters)
        {
            return new string(guessedLetters);
        }
    }
}
