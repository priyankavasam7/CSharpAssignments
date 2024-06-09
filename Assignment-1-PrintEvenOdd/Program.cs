namespace Assignment_1_PrintEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Target number: ");
            int target=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice: (\"E\" for even \"O\" for Odd)");
            char choice=Convert.ToChar(Console.ReadLine());
            PrintEvenOdd(target, choice);
        }

        static void PrintEvenOdd(int target, char choice)
        {
            int targetNumber=target;
            char choiceSelected=choice;
            if (choiceSelected == 'E')
            {
                Console.WriteLine($"Even Numbers until {targetNumber} are : ");
                for(int i = 0;i< targetNumber; i+=2)
                {
                    Console.Write(i + " ");
                }
            }
            else 
            {
                Console.WriteLine($"Odd Numbers until {targetNumber} are : ");
                for (int i = 1; i < targetNumber; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
        
    }


}
