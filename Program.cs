using System;
using TempConversionClass;

namespace TempConversionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            char fromScale;
            char toScale;

            while (true)
            {  
                Console.WriteLine("What temperature do you want to convert? (int number please)");

                int fromTemp = int.Parse(Console.ReadLine());
                Console.WriteLine("What temperature scale is " + fromTemp + " in? (C F or K)");
                fromScale = Console.ReadLine()[0];

          

                Console.WriteLine("What temperature do you want to convert to? (C F or K)");
                toScale = Console.ReadLine()[0]; 

                ConversionCalculator calculator = new ConversionCalculator(fromTemp, fromScale);

                switch(toScale)
                {
                    case 'C':
                        Console.WriteLine(fromTemp + " in Celsius is " + calculator.toCelsius());
                        break;
                    case 'F':
                        Console.WriteLine(fromTemp + " in Fahrenheight is " + calculator.toFahrenheight());
                        break;
                    case 'K':
                        Console.WriteLine(fromTemp + " in Kelvin is " + calculator.toKelvin());
                        break;
                    }
                }
        }
    }
}
