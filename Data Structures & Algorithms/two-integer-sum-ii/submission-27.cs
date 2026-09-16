public class Solution {
    public int[] TwoSum(int[] numbers, int target) //numbers=[-5,-5,-3,0,2] target=-10
    {
        int left = 0, right = numbers.Length - 1;

        while (left < right)
        {
            var currentSum = numbers[left] + numbers[right];

            if (currentSum > target) right--;
            else if (currentSum < target) left++;
            else return [left + 1, right + 1];
        }

        return [];
    }
}
