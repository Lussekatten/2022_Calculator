
bool runMe = true;

while (runMe)
{
    DisplayMenu();
    string key = Console.ReadKey().Key.ToString();
    string svar;

    switch (key)
    {
        case "D1":
            Console.Write("\nSpecify numbers (comma separated): ");
            string[] numbers = Console.ReadLine().Split(',');
            svar = AddNumbers(numbers).ToString();
            Console.WriteLine($"\nResult: {svar}" );
            break;
        case "D2":
            Console.Write("\nSpecify numbers (comma separated): ");
            string[] numbers2 = Console.ReadLine().Split(',');
            svar = SubtractNumbers(numbers2).ToString();
            Console.WriteLine($"\nResult: {svar}");
            break;
        case "D3":
            Console.Write("\nSpecify numbers (comma separated): ");
            string[] numbers3 = Console.ReadLine().Split(',');
            svar = MultiplyNumbers(numbers3).ToString();
            Console.WriteLine($"\nResult: {svar}");
            break;
        case "D4":
            Console.Write("\nSpecify numbers (comma separated): ");
            string[] numbers4 = Console.ReadLine().Split(',');
            svar = DivideNumbers(numbers4).ToString();
            Console.WriteLine($"\nResult: {svar}");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Do you want to try again? (y/n)");
    key = Console.ReadKey().Key.ToString();
    if (key.ToUpper() != "Y")
    {
        runMe = false;
    }

}

object MultiplyNumbers(string[] numbers)
{
    int result = 1;
    if (numbers.Length == 0 || numbers.Length == 1)
    {
        Console.WriteLine("Nothing to calculate");
        return 0;
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        result *= int.Parse(numbers[i]);
    }
    return result;
}

int AddNumbers(string[] numbers)
{
    if (numbers.Length == 0 || numbers.Length == 1)
    {
        Console.WriteLine("Nothing to calculate");
        return 0;
    }
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result+= int.Parse(numbers[i]);
    }
    return result;
}

int SubtractNumbers(string[] numbers)
{
    if (numbers.Length ==0 || numbers.Length == 1)
    {
        Console.WriteLine("Nothing to calculate");
        return 0;   
    }
    int result = int.Parse(numbers[0]);
    for (int i = 1; i < numbers.Length; i++)
    {
        result -= int.Parse(numbers[i]);
    }
    return result;
}

double DivideNumbers(string[] numbers)
{
    if (numbers.Length == 0 || numbers.Length == 1)
    {
        Console.WriteLine("Nothing to calculate");
        return 0;
    }

    for (int i = 1; i < numbers.Length; i++)
    {
        if (int.Parse(numbers[i])==0)
        {
            Console.WriteLine("Division with zero is not allowed");
            return 0;  
        }
    }

    double result = int.Parse(numbers[0]);
    for (int i = 1; i < numbers.Length; i++)
    {
        result /= int.Parse(numbers[i]);
    }
    return result;
}

void DisplayMenu()
{
    Console.Clear ();
    Console.WriteLine("Choose an operation" );
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division\n");
}
