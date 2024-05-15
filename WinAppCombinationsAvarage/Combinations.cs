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


    }
}
