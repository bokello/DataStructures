public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
         /* int rows = matrix.Length;
            int columns = matrix[0].Length;
                
            int left = 0;
            int right = columns  - 1;

            while(left <= right)
            {
               int midpoint = left + (right-left) / 2;
               int midpoint_element = matrix[midpoint / columns][midpoint%columns];

               if(midpoint_element == target)
                  return true;
                else if(target < midpoint_element)
                  right = midpoint - 1;
                else if(target > midpoint_element)
                  left = midpoint + 1;
                
            } 

            return false; */
        
          int rows = 0;
          int cols = matrix[0].Length - 1;
              
          while(rows < matrix.Length && cols >= 0)
          {
               if(matrix[rows][cols] == target)
                   return true;
               else if(matrix[rows][cols] < target)
                   rows++;
              else
                  cols--;              
          }
        
          return false;
    }
}