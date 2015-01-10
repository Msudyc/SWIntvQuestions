/*
Sort a linked list using insertion sort.

class Solution {
public:
    ListNode *insertionSortList(ListNode *head) {
        
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
        public static ListNode InsertionSortList(ListNode head)
        {
            if (null == head) 
                return head;

            ListNode cur = head.Next, tmp = null;

            while (cur != null)
            {
                tmp = head;
                while (tmp.Val < cur.Val && tmp != cur) 
                    tmp = tmp.Next;

                if (tmp != cur)
                {
                    int first = cur.Val, second;
                    while (tmp != cur)
                    {
                        second = tmp.Val;
                        tmp.Val = first;
                        first = second;
                        tmp = tmp.Next;
                    }

                    tmp.Val = first;
                }

                cur = cur.Next;
            }

            return head;
        }

        public static ListNode InsertionSortList2(ListNode head)
        {
            ListNode resultHead = head;
            ListNode remain = head.Next;
            resultHead.Next = null;

            ListNode p, q;
            while (remain != null)
            {
                p = resultHead;
                q = remain;
                remain = q.Next;

                if (p.Val > q.Val)
                {
                    q.Next = p;
                    resultHead = q;
                }
                else
                {
                    while (p.Next != null && p.Next.Val < q.Val)
                        p = p.Next;

                    q.Next = p.Next;
                    p.Next = q;
                }
            }

            return resultHead;
        }

        public static ListNode InsertionSortList3(ListNode head)
        {
            ListNode q = head;
            ListNode dummy = new ListNode(int.MinValue);
            while (q != null)
            {
                ListNode t = q.Next;
                q.Next = null;
                Insert(dummy, q);
                q = t;
            }

            return dummy.Next;
        }

        private static void Insert(ListNode head, ListNode i)
        {
            while (head.Next != null && head.Next.Val < i.Val)
                head = head.Next;

            if (head.Next == null)
                head.Next = i;
            else
            {
                i.Next = head.Next;
                head.Next = i;
            }
        }
    }
}