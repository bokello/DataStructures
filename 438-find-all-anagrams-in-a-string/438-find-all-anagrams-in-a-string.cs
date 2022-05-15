public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
    
    IList<int> output = new List<int>();
	int[] pCount = new int[26];
	int[] sCount = new int[26];
	int pLength = p.Length;
	
	
	for(int i=0;i < p.Length; i++)
	{
		pCount[p[i] - 'a']++;
	}
	
	
	int right=0;
	
	while(right < s.Length)
	{
		sCount[s[right] - 'a']++;
		
		if(right >= pLength)
		   sCount[s[right - pLength] - 'a']--;
			        
        if(sCount.SequenceEqual(pCount))
			output.Add(right-pLength + 1);
		
		right++;
	}
	
	return output;
    
    
    
    }
        
        
}        
        
    
