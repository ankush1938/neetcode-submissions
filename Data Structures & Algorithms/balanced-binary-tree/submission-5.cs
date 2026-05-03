/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        
        if (root == null){
            return true;
        }
        int left = Height(root.left);
        int right = Height(root.right);
        if(left > right){
            return left - right <= 1;
        }
        else{
            return right - left <= 1;
        }
    }
    private int Height(TreeNode root){
        int count = 1;
        if (root == null){
            return count;
        }
        int left = 0;
        int right = 0;
        
            left += Height(root.left);
       
            right += Height(root.right);
        
        if( left > right){
            count += left;
        }
        else{
            count += right;
        }
        return count;
    }
}
