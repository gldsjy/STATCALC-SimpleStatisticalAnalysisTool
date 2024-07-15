using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATCALC_SimpleStatisticalAnalysisTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StatCalc: Simple Statistical Analysis Tool");

            Console.WriteLine();

            int numofdataset = Validation.GetValidNumber("Enter number of data sets: ");
            int n = Validation.GetValidNumber("Enter sample size (n): ");
            Console.WriteLine();

            string[] datasetNames = new string[numofdataset];
            double[][] datasets = new double[numofdataset][];

            for (int i = 0; i < numofdataset; i++)
            {
                Console.Write($"Enter name of data set {i + 1}: ");
                datasetNames[i] = Console.ReadLine();

                datasets[i] = new double[n];

                Console.WriteLine($"Input data for {datasetNames[i]}:");
                for (int j = 0; j < n; j++)
                {
                    datasets[i][j] = Validation.GetValidDouble($"Input data {j + 1}/{n}: ");
                }

                Console.WriteLine();
            }

            Interface.PerformCalculations(datasetNames, datasets);
        }
    }
}
