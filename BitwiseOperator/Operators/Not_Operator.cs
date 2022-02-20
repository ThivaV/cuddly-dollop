namespace BitwiseOperators.Operators
{
    internal class Not_Operator
    {
        public void not_operator(int a)
        {
            byte _a = Convert.ToByte(a);
            byte result = (byte)~a;

            Console.WriteLine($"{Convert.ToString(a, 2).PadLeft(8, '0')}   =>  a: {a} ~");
            Console.WriteLine($"---------------------");
            Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}   =>  result: {result}");
            Console.WriteLine();
        }
    }
}
