public class Solution {
        public bool IsValid(string s) 
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if(IsOpening(c)) stack.Push(c);
                if(IsClosing(c))
                {
                    if(stack.Count > 0 && IsCorresponding(c, stack)) stack.Pop();
                    else return false;
                }
            }
            
            return stack.Count == 0;
        }

        bool IsOpening(char c) =>
            (c == '(') || (c == '[') || (c == '{');
        
        bool IsClosing(char c) =>
            (c == ')') || (c == ']') || (c == '}');

        bool IsCorresponding(char c, Stack<char> stack) =>
            (c == ')' && stack.Peek() == '(') ||
            (c == ']' && stack.Peek() == '[') ||
            (c == '}' && stack.Peek() == '{');
    }