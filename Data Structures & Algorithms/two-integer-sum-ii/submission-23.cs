public class Solution {
    public int[] TwoSum(int[] numbers, int target) //numbers=[-5,-5,-3,0,2] target=-10
    {
        for (var left = 0; left < numbers.Length; left++)
        {
            var needed = target - numbers[left];
            var right = BinarySearch(numbers, needed, left+1);

            if (right != -1) return [left + 1, right + 1];
        }

        return [];
    }

    private int BinarySearch(int[] numbers, int needed, int left) //numbers=[-5,-5,-3,0,2] needed=-10 l=0
    {
        var right = numbers.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            
            if (numbers[mid] == needed) return mid;
            if (numbers[mid] < needed) left = mid + 1;
            else right = mid - 1;
        }

        return -1;
    }
}
