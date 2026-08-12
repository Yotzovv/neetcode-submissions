public class Solution {
    public int[] TwoSum(int[] numbers, int target) //numbers=[-5,-5,-3,0,2] target=-10
    {

        for (var l = 0; l < numbers.Length; l++)
        {
            var needed = target - numbers[l];
            var r = BinarySearch(numbers, needed, l+1);
            
            if (r != -1) return [l+1, r+1];
        }

        return [];
    }

    private int BinarySearch(int[] numbers, int needed, int l)
    {
        var r = numbers.Length - 1;

        while (l <= r)
        {
            var mid = l + (r-l) / 2; 
            
            if (numbers[mid] == needed) return mid;
            if (numbers[mid] < needed) l = mid + 1;
            else r = mid - 1;
        }

        return -1;
    }
}
