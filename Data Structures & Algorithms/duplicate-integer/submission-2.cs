public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seenNumbers = new HashSet<int>();

        foreach(var num in nums)
        {
            if(!seenNumbers.Add(num)) return true;
        }

        return false;
    }
}