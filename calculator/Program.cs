
while (true)
{
    Console.Write("Enter the first number: ");
    if (!double.TryParse(Console.ReadLine(), out double firstNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }

    Console.Write("Enter the second number: ");
    if (!double.TryParse(Console.ReadLine(), out double secondNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }

    Console.Write("Enter an operation (+, -, *, /): ");
    string operation = Console.ReadLine();

    double result;

    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;

        case "-":
            result = firstNumber - secondNumber;
            break;

        case "*":
            result = firstNumber * secondNumber;
            break;

        case "/":
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                continue;
            }

            result = firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Invalid operation.");
            continue;
    }

    Console.WriteLine($"Result: {result}");

    Console.Write("Do you want to perform another calculation? (y/n): ");
    string again = Console.ReadLine();

    if (again?.ToLower() != "y")
    {
        break;
    }

    Console.WriteLine();
}