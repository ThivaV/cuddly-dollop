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
            int codeIndex = 0;

            while (cartIndex < shoppingCart.Count && codeIndex < codeList.Count)
            {
                string currentItem = shoppingCart[cartIndex];

                if (((codeList[codeIndex][0].Equals("anything")) || codeList[codeIndex][0].Equals(currentItem)) &&
                    hasOrder(shoppingCart, cartIndex, codeList[codeIndex])) 
                {
                    cartIndex += codeList[codeIndex++].Count;
                }
                else
                {
                    cartIndex++;
                }
            }

            return codeIndex == codeList.Count ? 1 : 0;
        }

        private bool hasOrder(List<string> shoppingCart, int cartIndex, List<string> codes)
        {
            foreach (var code in codes)
            {
                if (cartIndex < shoppingCart.Count && (code.Equals("anything") || shoppingCart[cartIndex].Equals(code))) 
                {
                    cartIndex++;
                }
                else 
                {
                    return false;
                }
            }

            return true;
        }
    }
}
