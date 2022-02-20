namespace LeetCode
{
    public class Three_Sum_Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<string> keys = new List<string>();
            List<List<int>> master_lst = new List<List<int>>();

            if (nums.Length == 0 || nums.Length < 3)
            {
                return master_lst.ToArray();
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int tot = nums[i] + nums[left] + nums[right];

                    if (tot == 0)
                    {
                        string key = nums[i] + ":" + nums[left] + ":" + nums[right];
                        var isMatch = keys.FirstOrDefault(x => x.Contains(key));

                        if (isMatch == null)
                        {
                            List<int> child_lst = new List<int>();
                            child_lst.Add(nums[i]);
                            child_lst.Add(nums[left]);
                            child_lst.Add(nums[right]);

                            master_lst.Add(child_lst);
                            keys.Add(key);
                        }

                        left += 1;
                        right -= 1;
                    }
                    else if (tot < 0)
                    {
                        left += 1;
                    }
                    else
                    {
                        right -= 1;
                    }
                }
            }

            return master_lst.ToArray();
        }
    }
}