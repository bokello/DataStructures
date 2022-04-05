public class Solution {
    public int CalPoints(string[] ops) {
        
        Stack<int> stk = new Stack<int>();
        int ans = 0;
        
        foreach(string rule in ops)
        {            
            if(rule.Equals("+"))
            {
               int top = stk.Pop();
               int newTop = top + stk.Peek();
               stk.Push(top);
               stk.Push(newTop);
            }
            else if(rule.Equals("C"))
                stk.Pop();
            else if(rule.Equals("D"))
                stk.Push(2 * stk.Peek());
            else
                stk.Push(int.Parse(rule));            
        }
        
        while(stk.Count != 0)
            ans += stk.Pop();
        
        return ans;
        
    }
}