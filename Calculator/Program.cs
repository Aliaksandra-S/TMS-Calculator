Console.WriteLine("~ К а л ь к у л я т о р ~\n");

while (true)
{
    var result = 0.0;
    var firstNum = 0.0;
    var secondNum = 0.0;
    var percent = 100.0;
    var operCount = 0;

    Console.WriteLine(new string('_', 30));
    Console.Write("\nВведите число: ");
    var input = Console.ReadLine();
    firstNum = ReadDoubleInput(input);

    Console.Write("Введите второе число (если его нет - нажмите Enter): ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        ShowShortMenu();
        operCount = 2;
    }
    else
    {
        secondNum = ReadDoubleInput(input);
        ShowFullMenu();
        operCount = 5;
    }

    var operNum = ReadOperationInput(0, operCount);
    if (operNum == 0)
    {
        Console.WriteLine("Уже уходите? :( Пока!");
        break;
    }

    if (operCount == 2 && operNum == 2)
    {
        Console.Write("Введите процент: ");
        input = Console.ReadLine();
        percent = ReadDoubleInput(input);
    }

    result = operCount == 2
                ? Calculator.DoOperationWithOneNumber(firstNum, percent, operNum)
                : Calculator.DoOperationWithTwoNumbers(firstNum, secondNum, operNum);
    if (double.IsNaN(result))
    {
        Console.WriteLine("Операция вызвала ошибку вычисления. Попробуйте заново.\n");
        break;
    }
    Console.WriteLine($"Результат: {result}");
}
static double ReadDoubleInput(string input)
{
    var result = 0.0;
    
    while (!double.TryParse(input, out result))
    {
        Console.WriteLine("Некорректный ввод! Введите еще раз.");
        input = Console.ReadLine();
    }
    return result;
}

static int ReadOperationInput(int lowerBound, int upperBound)
{
    var result = -1;
    var input = Console.ReadLine();
    while (!int.TryParse(input, out result) || result < lowerBound || result > upperBound)
    {
        Console.WriteLine("Некорректный ввод! Введите еще раз.");
        input = Console.ReadLine();
    }
    return result;
}

static void ShowShortMenu()
{
    Console.WriteLine("\nВыберите операцию:");
    Console.WriteLine("\t1 - Квадратный корень");
    Console.WriteLine("\t2 - Процент от числа");
    Console.WriteLine("\t0 - Выход");
    Console.Write("\nВведите номер операции: ");
}

static void ShowFullMenu()
{
    Console.WriteLine("\nВыберите операцию:");
    Console.WriteLine("\t1 - Сложение");
    Console.WriteLine("\t2 - Вычитание");
    Console.WriteLine("\t3 - Умножение");
    Console.WriteLine("\t4 - Деление");
    Console.WriteLine("\t5 - Остаток от деления");
    Console.WriteLine("\t0 - Выход");
    Console.Write("\nВведите номер операции: ");
}