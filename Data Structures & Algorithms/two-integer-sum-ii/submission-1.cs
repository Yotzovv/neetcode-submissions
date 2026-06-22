    public class Solution {
        public int[] TwoSum(int[] numbers, int target)
        {
            var result = new int[2];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] >= numbers[x]) continue;

                    if (numbers[i] + numbers[x] == target)
                    {
                        result[0] = i+1;
                        result[1] = x+1;
                    }
                }
            }

            return result;
        }
    }