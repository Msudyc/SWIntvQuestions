/*
Given a sorted linked list, delete all nodes that have 
duplicate numbers, leaving only distinct numbers from the 
original list. 

For example,
 Given 1.2.3.3.4.4.5, return 1.2.5.
 Given 1.1.1.2.3, return 2.3. 

class Solution {
public:
    ListNode *deleteDuplicates(ListNode *head) {
        
    }
};
*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public partial class LinkedListIntv
    {
        public static ListNode DeleteDuplicatesII(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode dummy = new ListNode(0);
            dummy.Next = head;

            ListNode p = dummy;
            ListNode q = head;

            while (q != null)
            {
                while (q != null && q.Next != null && q.Val == q.Next.Val)
                    q = q.Next;

                if (p.Next == q)
                    p = p.Next;
                else
                    p.Next = q.Next;

                q = q.Next;
            }

            return dummy.Next;
        }
    }
}