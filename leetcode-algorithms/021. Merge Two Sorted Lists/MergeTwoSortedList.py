# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def mergeTwoLists(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        
        
        result = currentNode = ListNode(0)     
        while l1 and l2 :
            if l1.val <= l2.val:
                currentNode.next = l1
                currentNode = l1
                l1 = l1.next
            else:
                currentNode.next = l2
                currentNode = l2
                l2 = l2.next
        
        currentNode.next = l1 or l2

        return result.next
                    