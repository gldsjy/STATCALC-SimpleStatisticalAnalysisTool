using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class FD
    {
        public static void GenerateFrequencyDistribution(string datasetName, double[] dataset)
        {
            Array.Sort(dataset);

            double currentValue = dataset[0];
            int frequency = 1;

            Console.WriteLine($"Frequency Distribution of {datasetName}:");

            for (int i = 1; i < dataset.Length; i++)
            {
                if (dataset[i] == currentValue)
                {
                    frequency++;
                }
                else
                {
                    Console.WriteLine($"{currentValue}: {frequency}");
                    currentValue = dataset[i];
                    frequency = 1;
                }
            }

            Console.WriteLine($"{currentValue}: {frequency}");
        }
    }
}
