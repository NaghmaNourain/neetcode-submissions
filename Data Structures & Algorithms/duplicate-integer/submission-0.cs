public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> result = new();
        foreach(int num in nums){
            if(result.Contains(num)){
                return true;
            }
            result.Add(num);
        }
        return false;
    }
}
