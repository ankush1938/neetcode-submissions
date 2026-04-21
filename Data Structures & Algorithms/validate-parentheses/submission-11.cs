public class Solution {
    public bool IsValid(string s) {
        bool ans = true;
        Stack<char> valids = new Stack<char>();
        foreach(char c in s){
            switch (c){
                case '{' : 
                valids.Push(c);
                break;
                case '(' : 
                valids.Push(c);
                break;
                case '[' : 
                valids.Push(c);
                break;
                case '}' : 
                if(valids.Count() > 0 && valids.Peek() == '{')
                { valids.Pop(); }
                else
                ans = false;
                break;
                
                case ']' : 
                if(valids.Count() > 0 && valids.Peek() == '[')
                { valids.Pop(); }
                else
                ans = false;
                break;
                
                case ')' : 
                if(valids.Count() > 0 && valids.Peek() == '(')
                { valids.Pop(); }
                else
                ans = false;
                break;
            }
        }
        if (valids.Count() > 0)
        { ans = false; }
        return ans;
    }
}
