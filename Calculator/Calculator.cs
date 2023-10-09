public class Calculator
{
    public static double DoOperationWithOneNumber(double number, double percent, int operation)
    {
        double result = double.NaN;

        switch (operation)
        {
            case 1:
                result = Math.Sqrt(number);
                break;
            case 2:
                result = number * percent * 0.01;
                break;
        }
        return result;
    }
    public static double DoOperationWithTwoNumbers(double firstNum, double secondNum, int operation)
    {
        double result = double.NaN;

        switch (operation)
        {
            case 1:
                result = firstNum + secondNum;
                break;
            case 2:
                result = firstNum - secondNum;
                break;
            case 3:
                result = firstNum * secondNum;
                break;
            case 4:
                if (secondNum != 0)
                    result = firstNum / secondNum;
                break;
            case 5:
                result = firstNum % secondNum;
                break;
        }
        return result;
    }
}

