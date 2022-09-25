namespace SelectionSort
{
    internal class StartUp
    {
        static void Main(string[] args) 
        {
            int[] array = new[] {10,20,2,4};

            BubbleSort(array);

            Console.WriteLine(String.Join(" ", array));
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                Swap(arr, i, min);
            }

        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            //arr[i] = arr[i] ^ arr[j];
            //arr[j] = arr[i] ^ arr[j];
            //arr[i] = arr[i] ^ arr[j];
         }
    }
}