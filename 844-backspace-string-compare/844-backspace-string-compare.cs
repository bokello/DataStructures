public class Solution {
    public bool BackspaceCompare(string s, string t) {
        
        string str1 = buildString(s);
        string str2 = buildString(t);
        
        if(str1.Equals(str2))
            return true;
        
        return false;
    }
    
    public string buildString(string str)
    {
        string result = string.Empty;
        Stack<char> stk = new Stack<Char>();
        
        for(int i=0;i < str.Length; i++)
        {
            
            if(str[i] != '#')
              stk.Push(str[i]);
            else if(stk.Count !=0)                   
              stk.Pop();      
        }
        
        while(stk.Count !=0)
            result += stk.Pop();
        
        return result;
        
    }
}