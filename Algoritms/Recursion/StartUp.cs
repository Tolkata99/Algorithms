

public static class StartUp
{
    public static void Main(string[] args)
    {
         int[] n = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToArray();

        int sum = Recursion(n, 0);

        Console.WriteLine(sum);

    }

    public static int Recursion(int[] arr, int startIndex)
    {
        if(startIndex == arr.Length - 1)
        {
            return arr[startIndex]; 
        }

        return arr[startIndex] + Recursion(arr, startIndex + 1);
    }
}
