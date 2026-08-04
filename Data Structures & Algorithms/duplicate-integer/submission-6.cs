public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var hashtable = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (hashtable.ContainsKey(num)) hashtable[num]++;
            else hashtable[num] = 1;
        }
        
        return hashtable.Any(x => x.Value > 1);
    }
}