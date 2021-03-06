using System;
using System.Text;
using System.Collections.Generic;

namespace myApp
{

	// Enum
	public enum Temperature
	{
		Freeze,
		Low,
		Warm,
		Boil
	}

    class Animal
    {
        static void Main(string[] args)
        {
        	Temperature micTemp = Temperature.Warm;

        	switch(micTemp)
        	{
        		case Temperature.Freeze:
        			Console.WriteLine("Temp on Freezing");
        			break;

        		case Temperature.Low:
        			Console.WriteLine("Temp on Low");
        			break;

        		case Temperature.Warm:
        			Console.WriteLine("Temp on Warm");
        			break;

        		case Temperature.Boil:
        			Console.WriteLine("Temp on Boil");
        			break;
        	}
        	
        }
    }
}