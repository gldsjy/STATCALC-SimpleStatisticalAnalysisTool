using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class MeasuresofV
    {
        public static void CalculateRange(string datasetName, double[] dataset)
        {
            double min = dataset[0];
            double max = dataset[0];
            foreach (double num in dataset)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }
            double range = max - min;

            Console.WriteLine($"{datasetName} Range: {range}");
        }

        public static void CalculateVariance(string datasetName, double[] dataset)
        {
            if (dataset.Length < 2)
            {
                Console.WriteLine("Variance calculation requires at least two data points.");
                return;
            }

            double sum = 0;
            foreach (double num in dataset)
            {
                sum += num;
            }
            double mean = sum / dataset.Length;

            double sumSquares = 0;
            foreach (double num in dataset)
            {
                sumSquares += Math.Pow(num - mean, 2);
            }
            double variance = sumSquares / (dataset.Length - 1);

            Console.WriteLine($"{datasetName} Variance: {variance}");
        }

        public static void CalculateStdDev(string datasetName, double[] dataset)
        {
            if (dataset.Length < 2)
            {
                Console.WriteLine("Standard deviation calculation requires at least two data points.");
                return;
            }

            double sum = 0;
            foreach (double num in dataset)
            {
                sum += num;
            }
            double mean = sum / dataset.Length;

            double sumSquares = 0;
            foreach (double num in dataset)
            {
                sumSquares += Math.Pow(num - mean, 2);
            }
            double stdDev = Math.Sqrt(sumSquares / (dataset.Length - 1));

            Console.WriteLine($"{datasetName} Standard Deviation: {stdDev}");
        }
    }
}
