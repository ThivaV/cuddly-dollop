namespace BitwiseOperators.Shift
{
    internal class Left_Shift
    {
        public void Shift(int val, int by) 
        {
            byte _val = (byte)val;
            var result = (byte)_val << by;

            Console.WriteLine($"{Convert.ToString(val, 2).PadLeft(8, '0')}    =>   {val} <<");
            Console.WriteLine($"{Convert.ToString(result, 2).PadLeft(8, '0')}    =>   {result}");
            Console.WriteLine();
        }

        public int leftRotate(int n, int d)
        {
            int INT_BITS = 32;

            /* In n<<d, last d bits are 0. 
            To put first 3 bits of n at
            last, do bitwise or of n<<d with
            n >>(INT_BITS - d) */
            return (n << d) | (n >> (INT_BITS - d));
        }
    }
}
