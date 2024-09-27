using System;

namespace Calculator
{
    public class Operations
    {
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Not applicable");
                return 0;
            }
            else
            {
                return (float)num1 / num2;
            }
        }
    }

    public class MainCalculator
    {
      

        public static void Method()
        {
            Console.WriteLine("Choose your operator(+,-,*,/)");  
            char op = Console.ReadLine()[0]; 

            Console.WriteLine("Enter first value.");
            if (int.TryParse(Console.ReadLine(), out int input1))
            {
                Console.WriteLine("Enter second value");
                if (int.TryParse(Console.ReadLine(), out int input2))
                {
                    Switch(op, input1, input2);  
                }
            }
        }

        public static void Switch(char op, int num1, int num2)
        {
            Operations operations = new Operations();  

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result is " + operations.Addition(num1, num2));
                    break;

                case '-':
                    Console.WriteLine("Result is " + operations.Subtract(num1, num2));
                    break;

                case '*':
                   Console.WriteLine("Result is " + operations.Multiply(num1, num2));
                    break;

                case '/':
                  Console.WriteLine("Result is " + operations.Divide(num1, num2));
                    break;

                default:
                    Console.WriteLine("Not a valid operator");
                    break;
            }
        }

        public static void Main(string[] args)  
        {
            Method();
        }
    }
}
