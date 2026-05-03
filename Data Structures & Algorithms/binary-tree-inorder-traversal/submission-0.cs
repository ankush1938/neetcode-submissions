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
    public List<int> InorderTraversal(TreeNode root) {
        if (root == null){
            return new List<int>();
        }
        List<int> left = InorderTraversal(root.left);
        left.Add(root.val);
        left.AddRange(InorderTraversal(root.right));
        return left;        
    }
}