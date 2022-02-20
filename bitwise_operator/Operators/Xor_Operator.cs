namespace bitwise_operator.Operators
{
    internal class Xor_Operator
    {
        public void xor_operator(int a, int b)
        {
            var result = a ^ b;

            Console.WriteLine($"{Convert.ToString(a, 2).PadLeft(8, '0')}   =>  a: {a} ^");
            Console.WriteLine($"{Convert.ToString(b, 2).PadLeft(8, '0')}   =>  b: {b}");
            Console.WriteLine($"---------------------");
            Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}   =>  result: {result}");
            Console.WriteLine();
        }
    }
}
