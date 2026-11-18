public class Solution {

    public string Encode(IList<string> strs) {
        string res = string.Empty;
        foreach(string str in strs){
             res += str.Length + "#" + str;
        }
        return res; 
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i =0;
        while (i< s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int length = int.Parse(s.Substring(i, j-i));
            i = j+1;
            j= i +length;
            string str = s.Substring(i, length);
            res.Add(str);
            i = j;
        }       
        return res;
   }
}
