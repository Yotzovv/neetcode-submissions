public class Solution {
    public int LongestConsecutive(int[] nums)   //        nums=[0,3,2,5,4,6,1,1]
    {
        if (nums.Length == 0) return 0;
        var hashmap = new Dictionary<int, int>();
        var longest = 0;

        foreach (var num in nums) // num=1   //hashmap=[{0:7},{1:7},{2:5},{3:2},{4:4},{5:4},{6:7}]
        {
            if (nums.Length == 0) return 0;
            if (hashmap.ContainsKey(num)) continue;
            
            // check if we connect 2 islands
            var left = num - 1;         //left=0
            var right = num + 1;        //right=2
            
            if (!hashmap.ContainsKey(left) && !hashmap.ContainsKey(right))
            {
                hashmap[num] = 1;
                continue;
            }
            
            if (hashmap.ContainsKey(left) && hashmap.ContainsKey(right))
            {
                var leftLength = hashmap[left];                      // 1
                var rightLength = hashmap[right];                    // 5

                var currentLength = leftLength + rightLength + 1;    // 1+5+1=7

                var leftBoundary = num - leftLength;                 // 1-1=0
                var rightBoundary = num + rightLength;               // 1+5=6

                hashmap[num] = currentLength;                        // {1:7}
                hashmap[leftBoundary] = currentLength;               // {0:7}
                hashmap[rightBoundary] = currentLength;              // {6:7}
                continue;
            }
            else if (hashmap.ContainsKey(right))
            {
                var rightLength = hashmap[right];
                var currentLength = rightLength + 1;

                var rightBoundary = num + rightLength;

                hashmap[num] = currentLength;
                hashmap[rightBoundary] = currentLength;

                continue;
            }
            else if (hashmap.ContainsKey(left))
            {
                //{6:5}
                hashmap[num] = hashmap[left] + 1;   //hashmap[6]=4+1=5

                var leftLength = hashmap.GetValueOrDefault(left, 0);    //4
                var leftBoundary = num - leftLength; //6-4=2
                hashmap[leftBoundary] += 1;
                
                continue;
            }
            
        }

        longest = hashmap.Values.Max();
        return longest;
    }
}
