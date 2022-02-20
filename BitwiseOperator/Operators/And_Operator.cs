namespace BitwiseOperators.Operators
{
    internal class And_Operator
    {
        public void and_operator(int a, int b)
        {
            var result = a & b;

            Console.WriteLine($"{Convert.ToString(a, 2).PadLeft(8, '0')}   =>  a: {a} &");
            Console.WriteLine($"{Convert.ToString(b, 2).PadLeft(8, '0')}   =>  b: {b}");
            Console.WriteLine($"---------------------");
            Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}   =>  result: {result}");
            Console.WriteLine();
        }

        public void find_odd_or_even(int a) 
        {
            var b = 1;
            var result = a & b;

            Console.WriteLine($"find_odd_or_even()");
            Console.WriteLine($"{Convert.ToString(a, 2).PadLeft(8, '0')}    =>   {a} &");
            Console.WriteLine($"{Convert.ToString(b, 2).PadLeft(8, '0')}    =>   {b}");
            Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}    =>   {result}");

            if (result == 1)
            {
                Console.WriteLine("ODD");
            }
            else
            {
                Console.WriteLine("EVEN");
            }
            Console.WriteLine();
        }
    }
}
