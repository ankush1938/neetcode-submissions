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
    public int KthSmallest(TreeNode root, int k) {
        List<int> arr = smallest(root);
        return arr[k - 1];
    }
    public List<int> smallest(TreeNode root) {
        
        if (root == null){
            return new List<int>();
        }
        List<int> arr = new List<int>();
        arr.AddRange(smallest(root.left));
        arr.Add(root.val);
        arr.AddRange(smallest(root.right));
        return arr;
    }
}
