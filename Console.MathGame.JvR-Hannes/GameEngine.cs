using MathGame.JvR_Hannes.Models;
using System.Diagnostics;

namespace MathGame.JvR_Hannes
{
    internal class GameEngine
    {
        internal void RandomGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            Stopwatch stopwatch = new Stopwatch();

            // Requesting the number of questions from the user
            Console.WriteLine("How many questions would you like to answer?");
            int numberOfQuestions;

            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                char operation = Helpers.GetRandomOperator(random);

                var correctAnswer = 0;
                var operationName = "";

                switch (operation)
                {
                    case '+':
                        correctAnswer = firstNumber + secondNumber;
                        operationName = "Addition";
                        break;
                    case '-':
                        correctAnswer = firstNumber - secondNumber;
                        operationName = "Subtraction";
                        break;
                    case '*':
                        correctAnswer = firstNumber * secondNumber;
                        operationName = "Multiplication";
                        break;
                    case '/':
                        var divisionNumbers = Helpers.GetDivisionNumbers();
                        firstNumber = divisionNumbers[0];
                        secondNumber = divisionNumbers[1];
                        
                        correctAnswer = firstNumber / secondNumber;
                        operationName = "Division";
                        break;
                }
                int userAnswer;
                stopwatch.Start();
                Console.WriteLine($"{firstNumber}{operation}{secondNumber}");
                var result = int.TryParse(Console.ReadLine(), out userAnswer);
                stopwatch.Stop();

                if (result && userAnswer == correctAnswer)
                {
                    Console.WriteLine("Your answer is correct!! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:0.0}", ts.TotalSeconds);

                if (i == numberOfQuestions - 1)
                {
                    Console.WriteLine($"Game Over. You final score is {score}/{numberOfQuestions}. You took {elapsedTime} seconds to answer the question.");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Random);
        }
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            Stopwatch stopwatch = new Stopwatch();

            // Requesting the number of questions from the user
            Console.WriteLine("How many questions would you like to answer?");
            int numberOfQuestions;

            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

            for (int i = 0; i < numberOfQuestions; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                stopwatch.Start();
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                stopwatch.Stop();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct!! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:0.0}", ts.TotalSeconds);

                if (i == numberOfQuestions - 1)
                {
                    Console.WriteLine($"Game Over. You final score is {score}/{numberOfQuestions}. You took {elapsedTime} seconds to answer the question.");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            Stopwatch stopwatch = new Stopwatch();

            // Requesting the number of questions from the user
            Console.WriteLine("How many questions would you like to answer?");
            int numberOfQuestions;

            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                stopwatch.Start();
                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var result = Console.ReadLine();
                stopwatch.Stop();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct!! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:0.0}", ts.TotalSeconds);

                if (i == numberOfQuestions - 1)
                {
                    Console.WriteLine($"Game Over. You final score is {score}/{numberOfQuestions}. You took {elapsedTime} seconds to answer the question.");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            Stopwatch stopwatch = new Stopwatch();

            // Requesting the number of questions from the user
            Console.WriteLine("How many questions would you like to answer?");
            int numberOfQuestions;

            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                stopwatch.Start();
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                stopwatch.Stop();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct!! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:0.0}", ts.TotalSeconds);

                if (i == numberOfQuestions - 1)
                {
                    Console.WriteLine($"Game Over. You final score is {score}/{numberOfQuestions}. You took {elapsedTime} seconds to answer the question.");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            // Implementing the Stopwatch function to time the user on the questions asked
            Stopwatch stopwatch = new Stopwatch();

            // Requesting the number of questions from the user
            Console.WriteLine("How many questions would you like to answer?");
            int numberOfQuestions;

            // Checking if the user inputs a desired input otherwise inform them to input the correct & desired input
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < numberOfQuestions; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                stopwatch.Start(); // Stopwatch starts before the question is asked
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                stopwatch.Stop(); // Stopwatch stops after the question is answered

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct!! Type any key to continue...");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                // Updating Stopwatch to show only 1 decimals
                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = string.Format("{0:0.0}", ts.TotalSeconds);

                if (i == numberOfQuestions - 1)
                {
                    Console.WriteLine($"Game Over. You final score is {score}/{numberOfQuestions}. You took {elapsedTime} seconds to answer the question.");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);

        }
    }
}
