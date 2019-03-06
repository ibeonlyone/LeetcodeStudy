# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        head0 = head
        while(head  and head.next):
            if(head.next.val == head.val):
                head.next = head.next.next
            else:
                head = head.next
        
        
        return head0