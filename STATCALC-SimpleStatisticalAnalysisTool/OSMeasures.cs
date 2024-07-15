using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class OSMeasures
    {
        public static void CalculateSkewness(string datasetName, double[] dataset)
        {
            double mean = CalculateMean(dataset);
            double sumSquares = CalculateSumOfSquares(dataset, mean);
            double sumCubedDeviations = 0;

            foreach (double value in dataset)
            {
                sumCubedDeviations += Math.Pow(value - mean, 3);
            }

            double skewness = (dataset.Length * sumCubedDeviations) / ((dataset.Length - 1) * (dataset.Length - 2) * Math.Pow(Math.Sqrt(sumSquares / dataset.Length), 3));
            Console.WriteLine($"{datasetName} Skewness: {skewness}");
        }

        public static void CalculateKurtosis(string datasetName, double[] dataset)
        {
            double mean = CalculateMean(dataset);
            double sumSquares = CalculateSumOfSquares(dataset, mean);
            double sumFourthPowerDeviations = 0;

            foreach (double value in dataset)
            {
                sumFourthPowerDeviations += Math.Pow(value - mean, 4);
            }

            double kurtosis = ((dataset.Length * (dataset.Length + 1) * sumFourthPowerDeviations) /
                              ((dataset.Length - 1) * (dataset.Length - 2) * (dataset.Length - 3) * Math.Pow(Math.Sqrt(sumSquares / dataset.Length), 4))) -
                              (3 * Math.Pow((dataset.Length - 1), 2) / ((dataset.Length - 2) * (dataset.Length - 3)));

            Console.WriteLine($"{datasetName} Kurtosis: {kurtosis}");
        }

        private static double CalculateMean(double[] dataset)
        {
            double sum = 0;
            foreach (double value in dataset)
            {
                sum += value;
            }
            return sum / dataset.Length;
        }

        private static double CalculateSumOfSquares(double[] dataset, double mean)
        {
            double sumSquares = 0;
            foreach (double value in dataset)
            {
                sumSquares += Math.Pow(value - mean, 2);
            }
            return sumSquares;
        }
    }
}
