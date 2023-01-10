import java.util.LinkedList;
import java.util.List;

/*
 * @lc app=leetcode id=216 lang=java
 *
 * [216] Combination Sum III
 */

// @lc code=start

/*
    Integer remain
 *  LinkedList<Integer> combinations
 *  int K total no. of combinations required
 *  n target number
 *  result List<List<Integer>>
 */

class Solution {

    
    public List<List<Integer>> combinationSum3(int k, int n) {
        

        List<List<Integer>> result = new ArrayList<List<Integer>>();
        LinkedList<Integer> comb  = new LinkedList<Integer>();

        backTrack(n,k,comb,0,result);

        return result;
    }

    private void backTrack(int remain,int k,  LinkedList<Integer> comb,int nextStart, List<List<Integer>> result)
    {
         if(remain == 0 && comb.size() == k)
         {
            result.add(new ArrayList<Integer>(comb));
            return;
         }
         else if(remain < 0 || comb.size() == k)
         {
            return;
         }

         for(int i=nextStart;i < 9; i++)
         {
            comb.add(i+1);
            backTrack(remain-i-1, k, comb, i+1, result);
            comb.removeLast();
         }

    }

    

}
// @lc code=end

