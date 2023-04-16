using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter the score of judge [" + (i + 1) + "] : ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = CalculateSum(RemoveHighestAndLowest(scores));
            Console.WriteLine("The contestant receives a total of {0:F2} points.", sum);
        }

        static double[] RemoveHighestAndLowest(double[] scores)
        {
            Array.Sort(scores);
            double[] trimmedScores = new double[6];
            Array.Copy(scores, 1, trimmedScores, 0, 6);
            return trimmedScores;
        }

        static double CalculateSum(double[] scores)
        {
            double sum = 0;
            foreach (double score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
