public class Solution {
    public int[] CountBits(int n) {
        int[] rst = new int[n+1];
        
        for (int i = 0; i <= n; i++) {    
            int count = 0;
            
            int num = i;
            int size = Convert.ToString(num, 2).Length;            
            
            for (int j = 1; j <= size; j++) {
                count += num & 1;
                num = num >> 1;
            }
            
            rst[i] = count;
        }
        
        return rst;
    }
}