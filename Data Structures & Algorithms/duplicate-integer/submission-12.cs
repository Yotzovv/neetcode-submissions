public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var hs = new HashSet<int>(nums).Count != nums.Length;

        return hs;
    }
}