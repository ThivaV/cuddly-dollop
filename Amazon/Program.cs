namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> codeList = new List<List<string>> { 
                new List<string> { "apple", "apple" }, 
                new List<string> { "banana", "anything", "banana" } 
            };

            List<string> shoppingCart = new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" };

            OA2021_FreshPromotion oA2021_Fresh = new OA2021_FreshPromotion();
            int result = oA2021_Fresh.freshPromotion(codeList, shoppingCart);
            Console.WriteLine(result);
        }
    }
}
