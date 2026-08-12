public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var l = 0;
        var r = numbers.Length-1;

        while (numbers[l] + numbers[r] != target)
        {
            if (numbers[l] + numbers[r] > target) r--;
            if (numbers[l] + numbers[r] < target) l++;
        }
        
        return [l+1,r+1];
    }
}
