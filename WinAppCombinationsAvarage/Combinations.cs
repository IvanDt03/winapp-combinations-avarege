using System.Collections.Generic;

namespace WinAppCombinationsAvarage
{
    internal class Combinations
    {
        public List<double[]> combinations;

        public Combinations() => combinations = new List<double[]>();
        public int N { get; set; }
        public int K { get; set; }

        public void GenerateCombinations(double[] inputData, int n, int k, List<double> currentCombination, int start)
        {
            if (currentCombination.Count == k)
            {
                combinations.Add(currentCombination.ToArray());
                return;
            }

            for (int i = start; i < n; i++)
            {
                List<double> newCombination = new List<double>(currentCombination);
                newCombination.Add(inputData[i]);
                GenerateCombinations(inputData, n, k, newCombination, i + 1);
            }
        }

        public double StandardDeviation(int indexCombination)
        {
            double average  = combinations[indexCombination].Average();
            double sum = combinations[indexCombination].Sum(x => Math.Pow(x - average, 2));

            return Math.Round(Math.Sqrt(sum / (combinations[indexCombination].Length - 1)), 3);
        }
    }
}
