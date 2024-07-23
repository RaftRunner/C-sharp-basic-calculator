using System;

class Program
{
    static int addNum(int x, int y)
    {
        int sum = x + y;
        return sum;
    }

    static int subNum(int x, int y)
    {
        int subbedSum = x - y;
        return subbedSum;
    }

    static int multNum(int x, int y)
    {
        int product = x * y;
        return product;
    }

    static double dividedNum(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0; // Return 0 to indicate an error condition.
        }
        double dividedNum = x / y;
        return dividedNum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Which calculation would you like to perform? (+, -, *, /): ");
        string input = Console.ReadLine().Trim();

        if (input == "+")
        {
            Console.WriteLine("You have chosen addition");
            Console.WriteLine("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int sum = addNum(firstNum, secondNum);
            Console.WriteLine("Sum of the numbers is: " + sum);
        }
        else if (input == "-")
        {
            Console.WriteLine("You have chosen subtraction");
            Console.WriteLine("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int subbedSum = subNum(firstNum, secondNum);
            Console.WriteLine("Subtracted value of the numbers is: " + subbedSum);
        }
        else if (input == "*")
        {
            Console.WriteLine("You have chosen multiplication");
            Console.WriteLine("Please enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int product = multNum(firstNum, secondNum);
            Console.WriteLine("Product of the numbers is: " + product);
        }
        else if (input == "/")
        {
            Console.WriteLine("You have chosen division");
            Console.WriteLine("Please enter the first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            double divided = dividedNum(firstNum, secondNum);
            if (secondNum != 0)
            {
                Console.WriteLine("Division of the numbers is: " + divided);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid method next time");
        }
    }
}
