public class MinStack {
    private Stack<int> minStack;
    int min = -1;
    public MinStack() {
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        minStack.Push(val);
        if(minStack.Count() == 1){
            min = minStack.Peek();
        }
        else{
            min = Math.Min(val, min);
        }
    }
    
    public void Pop() {
        int popped = minStack.Pop();
        if (popped == min && minStack.Count() > 0){
            min = minStack.Peek();
            foreach(int i in minStack){
                min = Math.Min(i,min);
            }
        }
    }
    
    public int Top() {
        return minStack.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}
