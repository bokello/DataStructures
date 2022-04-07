public class Solution {
    public bool IsConsecutive(int[] nums) {
     
        Array.Sort(nums);
        
        for(int i=0;i + 1 < nums.Length; i++)
        {
            if(nums[i] + 1 != nums[i + 1])
                return false;
        }
        
        return true;
        
    }
}