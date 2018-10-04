/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head==null)
            return head;
        ListNode pointer = head;
        while(pointer.next!=null){
            if(pointer.val==(pointer.next).val){
                pointer.next=(pointer.next).next;
            }else{
                pointer=pointer.next;
            }
        }
        return head;
    }
}