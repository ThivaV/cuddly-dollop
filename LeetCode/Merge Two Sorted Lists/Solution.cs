namespace LeetCode
{
    internal class Merge_Two_Sorted_Lists_Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            ListNode dummy = new ListNode();
            ListNode tmp = dummy;

            while (true)
            {
                if (list1 == null)
                {
                    tmp.next = list2;
                    break;
                }

                if (list2 == null)
                {
                    tmp.next = list1;
                    break;
                }

                if (list1.val < list2.val)
                {
                    tmp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tmp.next = list2;
                    list2 = list2.next;
                }

                tmp = tmp.next;
            }

            return dummy.next;
        }
    }
}
