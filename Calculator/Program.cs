
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        addition(firstNum, secondNum);
        break;
    case '-':
        subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}

