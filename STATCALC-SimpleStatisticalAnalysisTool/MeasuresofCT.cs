using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class MeasuresofCT
    {
        public static void CalculateMean(string datasetName, double[] dataset)
        {
            double sum = 0;

            foreach (double value in dataset)
            {
                sum += value;
            }

            double mean = sum / dataset.Length;

            Console.WriteLine($"{datasetName} Mean: {mean}");
        }

        public static void CalculateMedian(string datasetName, double[] dataset)
        {
            Array.Sort(dataset);
            double median;
            int middle;

            if (dataset.Length % 2 == 0)
            {
                int newLength = dataset.Length + 1;
                middle = newLength / 2;
                double middleValue1 = dataset[middle - 1];
                double middleValue2 = dataset[middle];
                median = (middleValue1 + middleValue2) / 2.0;
            }
            else
            {
                middle = dataset.Length / 2;
                median = dataset[middle];
            }

            Console.WriteLine($"{datasetName} Median: {median}");
        }

        public static void CalculateMode(string datasetName, double[] dataset)
        {
            Array.Sort(dataset);

            double currentValue = dataset[0];
            List<double> modes = new List<double>();
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 1; i < dataset.Length; i++)
            {
                if (dataset[i] == currentValue)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        modes.Clear();
                        modes.Add(currentValue);
                        maxCount = currentCount;
                    }
                    else if (currentCount == maxCount)
                    {
                        modes.Add(currentValue);
                    }

                    currentValue = dataset[i];
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                modes.Clear();
                modes.Add(currentValue);
            }
            else if (currentCount == maxCount)
            {
                modes.Add(currentValue);
            }

            if (modes.Count == 1)
            {
                Console.WriteLine($"{datasetName} Mode: {modes[0]}");
            }
            else if (modes.Count > 1)
            {
                Console.WriteLine($"{datasetName} Modes: {string.Join(", ", modes)}");
            }
            else
            {
                Console.WriteLine($"{datasetName} doesn't have a mode.");
            }
        }
    }
}
