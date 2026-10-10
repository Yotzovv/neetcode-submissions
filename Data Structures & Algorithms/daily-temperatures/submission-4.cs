public class Solution {
    public int[] DailyTemperatures(int[] temperatures)//=[30,38,30,36,35,40,28]
    {
        // Create a result list filled with zeros.
        var result = new int[temperatures.Length];
        
        // Use a stack to store pairs of (temperature, index)
        // for days that haven't found a warmer day yet.
        var pairs = new Stack<(int, int)>();
        
        // Iterate through the temperature list:
        for (var i = 0; i < temperatures.Length; i++)
        {
            // While the stack is not empty and the current temperature
            // is warmer than the top of the stack:
            while (pairs.Count > 0 && temperatures[i] > pairs.Peek().Item1)
            {
                // Pop the top element.
                var pair = pairs.Pop();
                
                // Compute how many days passed and update the result.
                result[pair.Item2] = i - pair.Item2;
            }
            
            // Push the current day onto the stack.
            pairs.Push((temperatures[i], i));
        }

        return result;
    }
}
