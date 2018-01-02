using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5LabArrayOfInts
{
    class Program
    {
        private const int numberOfDays = 7; //I'm experimenting... setting number of days here
                                            //allows easier changes to code if you want to 
                                            //increase or decrease number of days.

        static void Main(string[] args)
        {
            int[] temps = new int[numberOfDays]; //set array length to 7 (or "numberOfDays")

            for (int counter = 0; counter < numberOfDays; counter++) //7 times, get temp for each day.
            {
                Console.WriteLine($"What's the temperature on day {counter + 1}?");
                temps[counter] = int.Parse(Console.ReadLine());
            }

            int total = 0; //initialize total temps for week

            foreach (int temp in temps) //add each element to total
            {
                total += temp;
            }

            int average = total / numberOfDays;  //finds average

            Console.WriteLine($"\nThe average temperature over the last 7 days was {average}."); //prints average
            Console.ReadLine();
        }
    }
}
