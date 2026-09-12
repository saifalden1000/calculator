Console.Write("Enter the first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

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
        result = firstNumber / secondNumber;
        break;

    default:
        Console.WriteLine("Invalid operation.");
        return;
}

Console.WriteLine($"Result: {result}");