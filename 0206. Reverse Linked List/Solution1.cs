namespace Test._0206._Reverse_Linked_List
{
    /**
     * Definition for singly-linked list.
     */

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

    /// <summary>
    /// Reverses a singly linked list in-place by iteratively adjusting pointers.
    ///
    /// Time Complexity: O(n) — each node is visited once.
    /// Space Complexity: O(1) — no additional data structures used.
    /// </summary>
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode? pre = null;
            ListNode? next;
            ListNode cur = head;

            while (cur != null) {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }

            return pre;
        }
    }
}
