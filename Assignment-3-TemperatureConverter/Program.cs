namespace Assignment_3_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Welcome to Temperature Converter---------");
            bool flag = true;
            do
            {
                Console.WriteLine("Select the Temperatue Conversion Choice: \n1. Celsius ('C') \n2.Fahrenheit ('F')");
                char conversionChoice=Convert.ToChar(Console.ReadLine());
                Console.WriteLine("What is the current temperature?");
                double currentTemperature = Convert.ToDouble(Console.ReadLine());
                double convertedTemperature;
                if(conversionChoice == 'F')
                {
                    convertedTemperature = ((currentTemperature * 9) / 5) + 32;
                    Console.WriteLine($"The current temperature is {convertedTemperature} degrees Celsius");
                }
                else if (conversionChoice == 'C')
                {
                    convertedTemperature = (currentTemperature -32) * 5/9;
                    Console.WriteLine($"The current temperature is {convertedTemperature} degrees Fahrenheit");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
                Console.WriteLine("Would you like to continue (Y/N)");
                char isTrue = Convert.ToChar(Console.ReadLine());
                if(isTrue == 'N')
                {
                    flag = false;
                    Console.WriteLine("Exiting...");
                }


            } while (flag);
        }
    }
}
