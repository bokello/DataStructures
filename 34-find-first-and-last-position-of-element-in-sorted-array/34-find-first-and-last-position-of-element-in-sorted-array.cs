public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
           int leftIdx = BinarySearchIndex(nums,true,target);
           int rightIdx = BinarySearchIndex(nums,false,target);
           return new int[] {leftIdx,rightIdx};
        
        
    }
    
    
      public int BinarySearchIndex(int[] nums, Boolean SearchLeft , int target)
        {   
           int left = 0;
           int right = nums.Length - 1;
           int i = -1;
                      
           while (left <= right)
           {
              int midpoint = left + (right-left) / 2;

              if(target > nums[midpoint])
                 left = midpoint + 1;
              else if (target < nums[midpoint])
                 right = midpoint -1;
              else
              {
                 i = midpoint;                 
                 if(SearchLeft)
                   right = midpoint - 1;
                 else
                   left = midpoint + 1;                  
              }                         
           }

           return i;
        }
}