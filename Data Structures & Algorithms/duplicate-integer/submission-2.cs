public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int> (nums);
        return seen.Count != nums.Length;
    }
}
