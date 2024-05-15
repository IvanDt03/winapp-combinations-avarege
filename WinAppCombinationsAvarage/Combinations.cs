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
    }
}
