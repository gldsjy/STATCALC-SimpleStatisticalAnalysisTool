using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class Summations
    {
        public static void CalculateSum(string datasetName, double[] dataset)
        {
            double sum = 0;
            foreach (double value in dataset)
            {
                sum += value;
            }
            Console.WriteLine($"{datasetName} Sum: {sum}");
        }

        public static void CalculateSumOfSquares(string datasetName, double[] dataset)
        {
            double sumSquares = 0;
            foreach (double value in dataset)
            {
                sumSquares += Math.Pow(value, 2);
            }
            Console.WriteLine($"{datasetName} Sum of Squares: {sumSquares}");
        }
    }
}
