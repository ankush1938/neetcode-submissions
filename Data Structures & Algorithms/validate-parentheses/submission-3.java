class Solution {
    public boolean isValid(String s) {
        Stack<Character> Braces = new Stack<>();
        for (int i = 0; i < s.length(); i++){
            char c = s.charAt(i);
            if(c=='(' || c=='[' || c=='{'){
                Braces.push(c);
                continue;
            }
            if(c==')'&& !Braces.isEmpty() && Braces.peek() == '('){
                Braces.pop();
            }
            else if(c==')'){
                Braces.push(')');
            }
            if(c=='}'&& !Braces.isEmpty() && Braces.peek() == '{'){
                Braces.pop();
            }
            else if(c=='}'){
                Braces.push('}');
            }
            if(c==']'&& !Braces.isEmpty() && Braces.peek() == '['){
                Braces.pop();
            }
            else if(c==']'){
                Braces.push(']');
            }
        }
        if(Braces.isEmpty())
        return true;
        else
        return false;
    }
}
