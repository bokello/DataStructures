/*
 * @lc app=leetcode id=153 lang=java
 *
 * [153] Find Minimum in Rotated Sorted Array
 */

// @lc code=start
class Solution {
    public int findMin(int[] nums) {
        
       // If the list has just one element then return that element.
       if (nums.length == 1) {
        return nums[0];
    }

    // initializing left and right pointers.
    int left = 0, right = nums.length - 1;
   
    if (nums[right] > nums[0]) {
        return nums[0];
    }

    
    while (right >= left) {
        // Find the mid element
        int mid = left + (right - left) / 2;

        if (nums[mid] > nums[mid + 1]) {
            return nums[mid + 1];
        }

        if (nums[mid - 1] > nums[mid]) {
            return nums[mid];
        }
      
        if (nums[mid] > nums[0]) {
            left = mid + 1;
        }
        else 
        {               
            right = mid - 1;
        }
    }
    return Integer.MAX_VALUE;


    }
}
// @lc code=end

