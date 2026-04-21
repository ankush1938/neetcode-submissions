public class MyStack {
    public class Node{
        public Node next;
        public Node prev;
        public int val;
        public Node(int value){
            this.next = null;
            this.prev = null;
            this.val = value;
        }
    }
    private Node curr;
    private Node head;
    public MyStack() {
        curr = new Node(-1);
        head = curr;
    }
    
    public void Push(int x) {
        if(curr.val == -1){
            curr.val = x;
            head = curr;
        }
        else{
            Node newnode = new Node(x);
            newnode.prev = curr;
            curr.next = newnode;
            newnode.prev = curr;
            curr = curr.next;
        }
    }
    
    public int Pop() {
        int val = 0;
        if(curr == head){
            val = head.val;
            head.val = -1;
            curr = head;
        }
        else{
            val = curr.val;
            curr = curr.prev;
            curr.next = null;
        }
        return val;
    }
    
    public int Top() {
        return curr.val;
    }
    
    public bool Empty() {
        if (curr == head && curr.val == -1){
            return true;
        }
        else{
            return false;
        }
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */