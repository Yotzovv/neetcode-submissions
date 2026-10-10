public class Solution {
    public int EvalRPN(string[] tokens) // tokens=["1","2","+","3","*","4","-"]     (1+2)*3-4=9-4=5
    {
        var stack = new Stack<int>(); // stack=[-,4,*,3,+,2,1]

        foreach (var token in tokens)
        {
            if (token == "+")
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(a+b);
            }
            else if (token == "-")
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(b-a);
            }
            else if (token == "*")
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(a*b);
            }
            else if (token == "/")
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(b/a);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
        
        return stack.Pop();
    }
}
