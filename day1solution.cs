using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Program
    {
        
       public static int Main(string[] args)
        {
            Console.WriteLine("hello");
            string[] inputData = System.IO.File.ReadAllLines(@"C:\Users\jamesnightingale\Advent of code\Day1_input_data.txt");
            int[] sonarMeasurements = Array.ConvertAll(inputData, int.Parse);

            int count = 0;
            int countHigher = 0;

            foreach (int number in sonarMeasurements)
            {
                if (number == sonarMeasurements[0])
                {
                    count++;
                }
                else if (number > sonarMeasurements[count - 1])
                {
                    countHigher++;
                    count++;

                }
                else
                {
                    count++;

                }
            }
            Console.Write(countHigher);
            return countHigher;
            
        }
        
    }
    
}
