using System.Text;

namespace SumOfCoins
{
    internal class StartUp
    {
        public static void Main()
        {
            int targetSum = int.Parse(Console.ReadLine());
            List<int> coins = new List<int> { 50,10 };

            Dictionary<int, int> wallet = new Dictionary<int, int>();
            try
            {
                 wallet = GreedySum(coins, targetSum);
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
                return;
            }
           

            wallet.OrderByDescending(c => c);

            PrintResult(wallet);

        }

        public static void PrintResult(Dictionary<int,int> wallet)
        {
            Console.WriteLine($"Number of coins to take: {wallet.Values.Sum()}");
            foreach (KeyValuePair<int, int> kvp in wallet)
            {
                Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
            }
        }

        public static Dictionary<int, int> GreedySum(List<int> coins, int targetSum)
        {
            coins = coins
                .OrderByDescending(c => c)
                .ToList();

            int currentSum = 0;

            Dictionary<int, int> wallet = new Dictionary<int, int>();

            for (int e = 0; e < coins.Count; e++)
            {
                int currSum = coins[e];
                

                if (currentSum + currSum > targetSum)
                {
                    continue;
                }

                currentSum += currSum;

                AddToWallet(currSum, wallet);

                e--;

                if (currentSum == targetSum)
                {
                    break;
                }
            }

            if(currentSum != targetSum)
            {
                throw new InvalidOperationException("Error");
            }

            return wallet;
        }

        private static void AddToWallet(int currSum, Dictionary<int, int> wallet)
        {
            if (!wallet.ContainsKey(currSum))
            {
                wallet[currSum] = 0;
            }

            wallet[currSum]++;
        }

       
    }
}