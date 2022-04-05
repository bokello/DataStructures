public class Solution {
    public bool IsValid(string s) {
        
          Dictionary<char,char> mappings = new Dictionary<char, char>();
          mappings.Add(')','(');
          mappings.Add('}','{');
          mappings.Add(']','[');
        
        
          Stack<char> stack = new Stack<char>();
          char[] word = s.ToCharArray();
                      
          foreach(char c in word)
          {              
              if(mappings.ContainsKey(c))
              {                   
                 char topElement = stack.Count == 0 ? '#' : stack.Pop();                  
                 if (topElement != mappings[c]) 
                    return false;                  
              }              
              else
                 stack.Push(c);
           }
                      
            return !stack.Any();     
        
    }
}