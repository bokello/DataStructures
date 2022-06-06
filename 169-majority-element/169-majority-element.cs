public class Solution {
    public int MajorityElement(int[] nums) {
        
        int candidate = -1;
        int count = 0;
        
        
        for(int i=0; i < nums.Length; i++)
        {
            if(count == 0)
                candidate = nums[i];
            
            count += (nums[i] == candidate) ? 1 : -1;
            
        }
        
        return candidate;
    }
}