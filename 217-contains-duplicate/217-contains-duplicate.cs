public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new HashSet<int>();
        
        foreach(int x in nums)
        {
            if(uniqueNums.Contains(x))
                return true;
            else
                uniqueNums.Add(x);            
        }
        
        return false;       
        
    }
}