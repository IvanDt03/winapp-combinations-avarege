using System.Collections.Generic;

namespace WinAppCombinationsAvarage
{
    internal class Combinations
    {
        private List<double[]> combinations;
        public int N { get; private set; }
        public int K { get; } = 4;

        public Combinations(double[] inputData)
        {
            combinations = new List<double[]>();
            N = inputData.Length;
        }

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
