public class Solution {
    public int MinDeletions(string s) {
        
        int[] frequency = new int[26];
        
        for(int i=0;i < s.Length; i++)
            frequency[s[i] - 'a']++;
        
        int deleteCount = 0;
        
        HashSet<int> seenFrequencies = new HashSet<int>();
        
        for(int i=0;i < 26;i++)
        {            
            while(frequency[i] > 0 && seenFrequencies.Contains(frequency[i]))
            {
                frequency[i]--;
                deleteCount++;
            }
            
            seenFrequencies.Add(frequency[i]);
        }
                
        return deleteCount;
        
    }
}