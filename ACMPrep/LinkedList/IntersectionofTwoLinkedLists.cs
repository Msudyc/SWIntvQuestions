﻿/*
Write a program to find the node at which the intersection
of two singly linked lists begins.

For example, the following two linked lists: 
A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3

begin to intersect at node c1.

Notes: 
If the two linked lists have no intersection 
at all, return null.

The linked lists must retain their original 
structure after the function returns.

You may assume there are no cycles anywhere 
in the entire linked structure.

Your code should preferably run in O(n) time
and use only O(1) memory.

class Solution {
public:
    ListNode *getIntersectionNode(ListNode *headA, ListNode *headB) {
        
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
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == headB)
                return headA;
            
            ListNode pa = headA;
            ListNode pb = headB;
            
            while (pa != null && pb != null)
            {
                pa = pa.Next;
                pb = pb.Next;
            }
            
            if (pa == null)
                pa = headB;
            if (pb == null)
                pb = headA;
            
            while (pa != null && pb != null)
            {
                pa = pa.Next;
                pb = pb.Next;
            }
            
            if (pa == null)
                pa = headB;
            if (pb == null)
                pb = headA;
            
            while (pa != null && pb != null)
            {
                if (pa == pb)
                    return pa;
                
                pa = pa.Next;
                pb = pb.Next;
            }
            
            return null;
        }
    }
}