public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        
        if(s1.Length > s2.Length)
            return false;
        
        for(int i=0;i < s1.Length; i++)
        {
            arr1[s1[i] - 'a']++;
            arr2[s2[i] - 'a']++;
        }
        
        for(int j=0;j < s2.Length - s1.Length;j++)
        {
            if(arr1.SequenceEqual(arr2))
                return true;
            
            arr2[s2[(j + s1.Length)] - 'a']++;
            arr2[s2[j] - 'a']--;
            
        }
        
        
        return arr1.SequenceEqual(arr2);
    
    }
    
    
    
}