/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root,root);
    }
    public bool IsMirror(TreeNode n1,TreeNode n2){
    if(n1==null&&n2==null)
        return true;
    if(n1==null||n2==null)
        return false;
    return (n1.val==n2.val)&& IsMirror(n1.right,n2.left)&&IsMirror(n1.left,n2.right);

    }
}   

