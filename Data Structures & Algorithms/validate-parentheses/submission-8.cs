public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        
        foreach (char c in s) {
            if (!closeToOpen.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }
            
            if (stack.Count > 0 && stack.Peek() == closeToOpen[c]) stack.Pop();
            else return false;
        }

        return stack.Count == 0;
    }
}
