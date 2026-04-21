class MinStack {
    private Stack<Integer> minStack;
    public MinStack() {
        minStack = new Stack<Integer>();
    }
    
    public void push(int val) {
        minStack.push(val);
    }
    
    public void pop() {
        minStack.pop();
    }
    
    public int top() {
        int top = minStack.peek();
        return top;
    }
    
    public int getMin() {
        int min = minStack.peek();
        for(int num : minStack){
            if(num < min){
                min = num;
            }
        }
        return min;
    }
}
