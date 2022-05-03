public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> set = new HashSet<int>();
        
        foreach(int num in nums)
        {
            if(!set.Contains(num))
                set.Add(num);
            else
                return true;
        }
        
        return false;
        
    }
}