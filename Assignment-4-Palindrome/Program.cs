namespace Assignment_4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Check Palindrome---------");
            Console.WriteLine("Enter value");
            string value=Console.ReadLine();
            string reversedValue = "";
            foreach (char c in value)
            {
                reversedValue = c + reversedValue;
            }
            if(reversedValue == value)
            {
                Console.WriteLine($"{value} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{value} is not a Palindrome");
            }
        }
    }
}
