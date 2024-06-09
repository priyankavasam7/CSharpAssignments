namespace Assignment_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".........Welcome to Calculator App.........");
            bool flag = true;
            do
            {
                Console.WriteLine("Select the operation you would like to perform: \n(Type the character shown in the brackets)");
                Console.WriteLine("1. Addition ('+') \n2. Subtractin ('-')\n3. Multiplication ('*')\n4. Division ('/')");
                char operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int result;
                switch (operation)
                {
                    case '+': result= firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result} ");
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result} ");
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result} ");
                        break;
                    case '/':
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result} ");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y/N)");
                char isTrue = Convert.ToChar(Console.ReadLine());
                if(isTrue == 'N')
                {
                    flag=false;
                    Console.WriteLine("Exiting...");
                }
            } while (flag);
        }
    }
}
