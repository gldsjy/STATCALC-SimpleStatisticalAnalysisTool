using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class Interface
    {
        public static void PerformCalculations(string[] datasetNames, double[][] datasets)
        {
            Console.WriteLine("Choose the calculations you want to perform:");
            Console.WriteLine("Press y for Yes and n for No");
            Console.WriteLine();

            List<Action<string, double[]>> selectedCalculations;
            selectedCalculations = new List<Action<string, double[]>>();


            if (Validation.YesOrNo("Frequency Distributions (y/n): "))
            {
                selectedCalculations.Add(FD.GenerateFrequencyDistribution);
            }

            Console.WriteLine();

            Console.WriteLine("Measures of Central Tendency:");
            if (Validation.YesOrNo("Mean (y/n): "))
            {
                selectedCalculations.Add(MeasuresofCT.CalculateMean);
            }
            if (Validation.YesOrNo("Median (y/n): "))
            {
                selectedCalculations.Add(MeasuresofCT.CalculateMedian);
            }
            if (Validation.YesOrNo("Mode (y/n): "))
            {
                selectedCalculations.Add(MeasuresofCT.CalculateMode);
            }

            Console.WriteLine();

            Console.WriteLine("Summations:");
            if (Validation.YesOrNo("Sum (y/n): "))
            {
                selectedCalculations.Add(Summations.CalculateSum);
            }
            if (Validation.YesOrNo("Sum of Squares (y/n): "))
            {
                selectedCalculations.Add(Summations.CalculateSumOfSquares);
            }

            Console.WriteLine();

            Console.WriteLine("Measures of Variability:");
            if (Validation.YesOrNo("Range (y/n): "))
            {
                selectedCalculations.Add(MeasuresofV.CalculateRange);
            }
            if (Validation.YesOrNo("Variance (y/n): "))
            {
                selectedCalculations.Add(MeasuresofV.CalculateVariance);
            }
            if (Validation.YesOrNo("Standard Deviation (y/n): "))
            {
                selectedCalculations.Add(MeasuresofV.CalculateStdDev);
            }

            Console.WriteLine();

            Console.WriteLine("Other Statistical Measures:");
            if (Validation.YesOrNo("Skewness (y/n): "))
            {
                selectedCalculations.Add(OSMeasures.CalculateSkewness);
            }
            if (Validation.YesOrNo("Kurtosis (y/n): "))
            {
                selectedCalculations.Add(OSMeasures.CalculateKurtosis);
            }

            Console.WriteLine();

            Console.WriteLine("Processing...");

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Results:");

            Console.WriteLine();


            foreach (var calculation in selectedCalculations)
            {
                for (int i = 0; i < datasets.Length; i++)
                {
                    calculation(datasetNames[i], datasets[i]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("All calculations completed.");

            Console.ReadKey();
        }
    }
}
