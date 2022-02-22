using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    internal class OA2021_FreshPromotion
    {
        public int freshPromotion(List<List<string>> codeList, List<string> shoppingCart)
        {
            int cartIndex = 0;
            foreach (var codes in codeList)
            {
                bool result = hasOrder(shoppingCart, cartIndex, codes);
            }
        }

        private bool hasOrder(List<string> shoppingCart, int cartIndex, List<string> codes)
        {
            int start = 0;
            int end = 0;
            for (int i = 0; i < codes.Count; i++)
            {
                if ((shoppingCart[cartIndex] == codes[i]) || (shoppingCart[cartIndex] == "anything"))
                {

                }
            }
        }
    }
}
