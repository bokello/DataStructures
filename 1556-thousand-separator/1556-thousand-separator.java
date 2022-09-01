class Solution {
    public String thousandSeparator(int n) {
        
        StringBuilder sb = new StringBuilder(String.valueOf(n));
		int i = sb.length();

		while(i > 3) 
        {
			sb.insert(i-3, '.');
			i-=3;
		} 
        
		return sb.toString();
    }
}