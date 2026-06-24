public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];
        
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Any() && temperatures[i] > temperatures[stack.Peek()]) 
            {
                var j = stack.Pop();
                result[j] = i - j;
            }

            stack.Push(i);
        }
        
        return result;
    }
}
