namespace Searching_Algorithm
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3 };
            //linear search
            //binary search == ordered data !!!!!

            Console.WriteLine(BinarySearch(arr, 1, 0, 2));
        }

        public static int BinarySearch(int[] arr, int s, int l, int r)
        {
            while (r >= l)
            {
                int midIndex = (l + r) / 2;

                if (s > arr[midIndex])
                {
                    l = midIndex + 1;
                }
                else if (s < arr[midIndex])
                {
                    r = midIndex - 1;
                }
                else
                {
                    return midIndex;    
                }

               
            }

            return -1;
        }
    }
}