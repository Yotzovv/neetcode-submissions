public class Solution {
    public int[] TwoSum(int[] numbers, int target) //numbers=[-5,-5,-3,0,2] target=-10
    {
        var hashmap = new Dictionary<int, int>();

        for (var i = 0; i < numbers.Length; i++)
        {
            var needed = target - numbers[i];
            if (hashmap.ContainsKey(needed)) return [hashmap[needed], i + 1];
            hashmap[numbers[i]] = i + 1;
        }

        return [];
    }
}
