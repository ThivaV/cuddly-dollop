// See https://aka.ms/new-console-template for more information
using System;
using BitwiseOperators.Operators;
using BitwiseOperators.Shift;

namespace BitwiseOperators 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Bitwise operators!");
            Console.WriteLine();

            int ori = 0;

            // 1. AND  & (both)
            Console.WriteLine("1. AND (&) Operation");
            And_Operator ao = new And_Operator();
            ao.and_operator(25, 4);
            ao.find_odd_or_even(100);

            // 2. OR   | (either)
            Console.WriteLine("2. OR (|) Operation");
            Or_Operator oo = new Or_Operator();
            oo.or_operator(25, 4);

            // 3. XOR  ^ (exclusive or inclusive)
            Console.WriteLine("3. XOR (^) Operation");
            Xor_Operator xo = new Xor_Operator();
            xo.xor_operator(25, 4);

            // 4. NOT  ~ (invert)
            Console.WriteLine("4. NOT (~) Operation");
            Not_Operator nt = new Not_Operator();
            nt.not_operator(25);

            Console.WriteLine("Bitwise shifting!");
            Console.WriteLine();

            // 5. Left Shift <<
            Console.WriteLine("5. Left Shift (<<) Operation");
            Left_Shift ls = new Left_Shift();
            ls.Shift(100000, 1);

            ori = 43261596;
            int lr = ls.leftRotate(ori, 1);
            Console.WriteLine($"left rotate: from {ori} to {lr}");
            Console.WriteLine();

            // 6. Right Shift >>
            Console.WriteLine("6. Right Shift (>>) Operation");
            Right_Shift rs = new Right_Shift();
            rs.Shift(25, 1);

            ori = 43261596;
            int rr = rs.rightRotate(ori, 1);
            Console.WriteLine($"right rotate: from {ori} to {rr}");
            Console.WriteLine();
        }
    }
}
