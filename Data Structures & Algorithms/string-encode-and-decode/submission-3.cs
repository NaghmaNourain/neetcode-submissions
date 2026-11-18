public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encodedString = new StringBuilder();
        if(strs.Count() == 0) {
            return encodedString.ToString();
        }
        char delimiter = '#';
        foreach( string str in strs){
            encodedString.Append(str.Length).Append(delimiter).Append(str);
        }
        return encodedString.ToString();
    }

    public List<string> Decode(string s) {

        List<string> result = new List<string>();
        if(s.Length < 2){
            return result;
        }
        char delimiter = '#';
        int i = 0;
        while( i < s.Length){
            int j = i;
            while (j < s.Length && s[j] != delimiter){
                j++;
            }
            // Parse the entire number substring between i and j (handles 10, 100, etc.)
        string lengthStr = s.Substring(i, j - i);
        int.TryParse(lengthStr, out int length);

        // Extract the exact word after '#'
        string res = s.Substring(j + 1, length);
        result.Add(res);

        // Move pointer to the start of the next length prefix
        i = j + 1 + length;   
        }
        return result;
   }
}
