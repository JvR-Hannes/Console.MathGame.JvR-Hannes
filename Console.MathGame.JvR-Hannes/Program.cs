using System.Diagnostics;

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name.ToUpper();
}

void Menu(string name)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game. It's great that you're working on improving yourself\n");

    var isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine(@$"What game would you like to play today? Choose from the options below:

    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    R - Random Game
    Q - Quit the Program");

        Console.WriteLine("----------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "r":
                RandomGame("Random game");
                break;
            case "q":
                Console.WriteLine("Goodbye!");
                isGameOn = false;
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid Input!");
                Environment.Exit(1);
                break;
        }
    } while (isGameOn);
}

void RandomGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
}

void DivisionGame(string message)
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
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        stopwatch.Start();
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();
        stopwatch.Stop();

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
}

void MultiplicationGame(string message)
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
}

void SubtractionGame(string message)
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
}

void AdditionGame(string message)
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

    games.Add("");

}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
       firstNumber = random.Next(1, 99);
       secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}