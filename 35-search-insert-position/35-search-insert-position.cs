public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int pos = 0;
        
        int left = 0;
        int right = nums.Length - 1;
        
        while(left <= right)
        {
            
            int mid = left + (right - left) / 2;
            
            if(nums[mid] == target)
                return mid;
            else if(target < nums[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }
                        
        return left;
        
        
    }
}