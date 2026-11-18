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

    public List<string> Decode(string str) {

         List<string> res = new List<string> ();
        int i = 0;
        while(i < str.Length){
            int j = i;
            while (j < str.Length && str[j] != '#'){
                j++;
            }

            int length = int.Parse(str.Substring(i, j-i));
            i = j+1;
            j =i+ length;
            res.Add(str.Substring(i, length));
            j = i + length;
            i = j;
        }
        return res;
       
   }
}
