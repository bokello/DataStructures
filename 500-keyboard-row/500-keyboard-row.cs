public class Solution {
    
    private string firstRow = "qwertyuiop";
    private string secondRow = "asdfghjkl";
    private string thirdRow = "zxcvbnm";
    
    public string[] FindWords(string[] words) {
        
         List<string> result  = new List<string>();
                
         foreach(string str in words)
         {
             if(checkSequence(str.ToLower(),firstRow) || checkSequence(str.ToLower(),secondRow) || checkSequence(str.ToLower(),thirdRow))
                result.Add(str);
         }
        
        return result.ToArray();
    }
    
    private bool checkSequence(string word, string sequence)
    {
        for(int i=0;i < word.Length; i++)
        {
           if(!sequence.Contains(word[i]))
              return false;
        }
        
        return true;      
    }
    
}