public class Solution {
    public string ReverseStr(string s, int k) {
        
      char[] arr = s.ToCharArray();

      for(int i=0; i < arr.Length -1;i+= k * 2)
      {        
         int j = Math.Min(i + k -1, arr.Length -1);
         swap(arr,i,j);
      }

      return new string(arr);
        
    }
    
    public static void swap(char[] arr, int left, int right)
    {
       while(left < right)
       {
          char temp = arr[left];
          arr[left] = arr[right];
          arr[right] = temp;
          left++;
          right--;   
       }
   }
}