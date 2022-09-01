public class Solution {
    public int NumIslands(char[][] grid) {
       
        if(grid.Length == 0 || grid == null)
            return 0;
        
        int numIslands = 0;
        
        for(int i=0;i < grid.Length; i++)
        {
            for(int j=0;j < grid[i].Length ; j++)
            {
                
                if(grid[i][j] == '1')
                    numIslands += dfs(grid,i,j);
            }
        }
        
        return numIslands;
        
    }
    
    private int dfs(char[][] grid,int i,int j)
    {
       if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length ||
          grid[i][j] == '0')
           return 0;
        
        grid[i][j] = '0';
        dfs(grid,i + 1,j);
        dfs(grid,i - 1,j);
        dfs(grid,i,j + 1);
        dfs(grid,i,j - 1);
        
        return 1;
    }
    
    
    
}