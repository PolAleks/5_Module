namespace _5._5._5_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));

            Console.WriteLine(PowerUp(2,4));
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
        static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else if (pow == 1)
            {
                return N;
            }
            return N * PowerUp(N,--pow);
        }
    }
}