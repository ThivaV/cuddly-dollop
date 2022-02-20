// See https://aka.ms/new-console-template for more information
namespace LeetCode
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("LeetCode Works!");
            Console.WriteLine();

            // 1. 3Sum
            Console.WriteLine("1. 3Sum");
            int[] input = { -1, 0, 1, 2, -1, -4 };
            Three_Sum_Solution tss = new Three_Sum_Solution();
            tss.ThreeSum(input);

            // 2. Counting Bits
            Console.WriteLine("2. Counting Bits");
            Counting_Bits_Solution cbs = new Counting_Bits_Solution();
            cbs.CountBits(2);

            // 3. Merge 2 sorted lists
            Console.WriteLine("3. Merge 2 sorted lists");
            // Merge_Two_Sorted_Lists_Solution mtsls = new Merge_Two_Sorted_Lists_Solution();
            // mtsls.MergeTwoLists(lst1, lst2);

            // 4. Reverse Bits
            Console.WriteLine("4. Reverse Bits");
            Reverse_Bits_Solution rbs = new Reverse_Bits_Solution();
            rbs.ReverseBits(120);
        }
    }
}
