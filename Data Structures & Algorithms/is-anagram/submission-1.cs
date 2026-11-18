public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> count = new Dictionary<char, int>();

        for(int i =0;i<s.Length; i++){
            char a = s[i];
            char b = t[i];
            count[a] = count.GetValueOrDefault(a, 0) + 1;
            count[b] = count.GetValueOrDefault(b, 0) - 1;
        }
        return count.Values.All(x=> x == 0);
    }
}
