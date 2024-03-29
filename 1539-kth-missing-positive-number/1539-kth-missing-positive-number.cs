public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        
        int left = 0;
        int right = arr.Length-1;
        
        while(left <= right)
        {
            int pivot = left + (right - left) / 2;
            
            
            if(arr[pivot] - pivot - 1 < k)
                left = pivot + 1;
            else
                right = pivot - 1;
        }
        
        return left + k;
    }
}