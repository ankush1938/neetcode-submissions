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
        if (root.left == null && root.right == null){
            return true;
        }
        int left = Height(root.left);
        int right = Height(root.right);
        return (right - left) == 1 || (left - right) == 1;
    }
    private int Height(TreeNode root){
        int count = 1;
        if (root == null){
            return count;
        }
        if (root.left != null){
            count += Height(root.left);
        }
        else if (root.right != null){
            count += Height(root.right);
        }
        return count;
    }
}
