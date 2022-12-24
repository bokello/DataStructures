import javax.lang.model.util.ElementScanner14;

/*
 * @lc app=leetcode id=33 lang=java
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
class Solution {
    public int search(int[] nums, int target) {
        
          int left = 0;
          int right = nums.length - 1;

          while(left <= right)
          {
                int mid = left + (right - left) / 2;

                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] >= nums[left])
                {
                    if(target >= nums[left] && target < nums[mid])
                       right = mid - 1;
                    else
                       left = mid + 1;
                }
                else
                {

                    if(target <= nums[right] && target > nums[mid])
                        left = mid + 1;
                    else
                       right = mid - 1;
                }
          }

          return -1;
    }
}
// @lc code=end

