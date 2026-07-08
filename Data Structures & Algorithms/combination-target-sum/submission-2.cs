public class Solution {
    List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = new List<List<int>>();
        Array.Sort(nums);
        GetCombinations(0, new List<int>(), target, 0, nums);
        
        return result;
    }
    
    private void GetCombinations(int index, List<int> combination, int target, int total, int[] nums, int recursion=1)
    {
        Console.WriteLine($"\nRecursion={recursion}  Index={index}");
        if (total == target)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int j = index; j < nums.Length; j++)
        {
            Console.WriteLine($"combinations=[{string.Join(",", combination)}]    j={j}");
            if (combination.Sum() + nums[j] > target) return;
            combination.Add(nums[j]);
            GetCombinations(j, combination, target, combination.Sum(), nums, recursion + 1);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
