public class Solution {
    public bool IsPalindrome(string s) {
    
        if(s == null ){
            return false;
        }
        if ( s == " ") { return true;}
        int start = 0;
        int end = s.Length -1;
        // use two pointers to get the star and end of the string
        while(start < end){
            while(start< end && !IsAlphaNum(s[start])){
                    start++;
            }
            while(end > start && !IsAlphaNum(s[end])){
                end--;
            }
            if(char.ToLowerInvariant(s[start]) != char.ToLowerInvariant(s[end])){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
    public static bool IsAlphaNum(char c){
			c = char.ToLowerInvariant(c);
			return (( c >= 'a' && c <= 'z' )|| (c >='0' && c <= '9'));
		
    }
}
