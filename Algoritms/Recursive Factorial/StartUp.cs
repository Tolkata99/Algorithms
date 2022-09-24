namespace Recursive_Factorial
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = RecursiveFactorial(n);

            Console.WriteLine(num);
        }

        public static int RecursiveFactorial(int n)
        {

            if(n == 0)
            {
                return 1;
            }

            return n * RecursiveFactorial(n - 1);
        }


    }
}