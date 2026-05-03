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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (Search(root, key)){
            return Remove(root, key);
        }
        else{
            return root;
        }
    }
    private TreeNode Remove(TreeNode root, int key){
        if (root == null){
            return root;
        }
        if (root.val > key){
            root.left = Remove(root.left, key);
        }
        else if (root.val < key){
            root.right = Remove(root.right, key);
        }
        else{
            if (root.left == null){
                return root.right;
            }
            else if (root.right == null){
                return root.left;
            }
            else{
                int minVal = minval(root);
                root.val = minVal;
                root.left = Remove(root.left, minVal);                
            }
        }
        return root;
    }
    private int minval(TreeNode root){
        while (root != null && root.left != null){
            root = root.left;
        }
        return root.val;
    }
    private bool Search(TreeNode root, int key){
        if (root == null){
            return false;
        }
        if (key > root.val){
            return Search(root.right, key);
        }
        else if (key < root.val){
            return Search(root.left, key);
        }
        else{
            return true;
        }
    }
}