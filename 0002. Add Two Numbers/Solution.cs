namespace Test._0002._Add_Two_Numbers
{
    // Definition for singly-linked list.
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

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode curr = head;
            var carry = 0;

            while (l1 != null || l2 != null || carry > 0) {
                var sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                curr.next = new ListNode(sum % 10);
                carry = sum / 10;
                
                curr = curr.next;
            }

            head = head.next;
            return head;
        }
    }
}
