public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int rows = 0;
        int cols = matrix[0].Length - 1;
        
        while(rows < matrix.Length && cols >= 0)
        {
            if(matrix[rows][cols] == target)
            {
                return true;
            }
            else if(matrix[rows][cols] < target)
            {
                rows++;                
            }
            else if(matrix[rows][cols] > target )
            {
                cols --;
            }
        }
        
        return false;
        
    }
}