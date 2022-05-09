public class Solution {
    
        public IList<string> LetterCombinations(string digits) {
         
           IList<string> result = new List<string>(); 
            
             if(digits == null || digits.Length == 0)
                return result;            
            
           string[] mappings = new string[]                         {"0","1","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
           string current = string.Empty;
           char[] digitsArr = digits.ToCharArray();
            
            backtrack(result,digitsArr,current,0,mappings);           

            return result;

        }

        public void backtrack(IList<string> result, char[] digits,string current,int index,string[] mapping)
        {             
          if(index == digits.Length)
          {
              result.Add(current);
              return;
          }
          
          string letters = mapping[digits[index] - '0'];

          for(int i=0;i < letters.Length;i++)
          {
               backtrack(result,digits,current + letters[i],index + 1,mapping);
          }

        }      
}