namespace tuple_taskss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            (int sumEven, int Odd) tuple = Sum(arr);
            Console.WriteLine(tuple.sumEven);
            Console.WriteLine(tuple.Odd);
        }
        static(int,int) Sum(int[] arr)
        {
            int sumOdd = 0;
            int sumEvenn = 0;
            foreach (int num in arr)
            {
                if(num%2 == 0)
                {
                    sumEvenn += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            return (sumEvenn, sumOdd);
        }
    }
}