var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. It's great that you're working on improving yourself\n");
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
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "r":
            RandomGame("Random game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye!");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input!");
            Environment.Exit(1);
            break;
    }
}

void RandomGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
    // Insert StartTimer() here
    var random = new Random();
}