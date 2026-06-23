 public class Solution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            var result = new List<List<int>>();
            var seen = new HashSet<string>();

            for (int a = 0; a < nums.Length; a++)
            {
                for (var b = a + 1; b < nums.Length; b++)
                {
                    for (var c = b + 1; c < nums.Length; c++)
                    {
                        if(nums[a] + nums[b] + nums[c] != 0) continue;

                        var triplet = new List<int> { nums[a], nums[b], nums[c] };
                        triplet.Sort();
                        
                        if(seen.Add(string.Join(",", triplet)))
                            result.Add(triplet);
                    }
                }
            }

            return result.ToList();
        }
    }