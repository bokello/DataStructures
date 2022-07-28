class Solution {
    public boolean isAnagram(String s, String t) {
        
        int[] alphabets = new int[26];
        
        
        if(s.length() != t.length())
            return false;
        
        for(int i=0;i < s.length();i++)
        {
            alphabets[s.charAt(i) - 'a']++;
            alphabets[t.charAt(i) - 'a']--;
        }
        
        for(int n : alphabets)
        {
            if(n != 0)
                return false;
        }
        
        return true;
        
        
    }
}