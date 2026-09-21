public class Solution {
    public int EvalRPN(string[] tokens) // tokens=["1","2","+","3","*","4","-"]     (1+2)*3-4=9-4=5
    {
        var stack = new Stack<string>(tokens);  // stack=[-,4,*,3,+,2,1]
        return DFS(stack);
    }

    private int DFS(Stack<string> stack)
    {
        var token = stack.Pop();
        if (token != "-" && token != "+"
            && token != "*" && token != "/") return int.Parse(token);
        
        var left = DFS(stack);
        var right = DFS(stack);
        
        return token switch
        {
            "+" => left + right,
            "-" => right - left,
            "*" => left * right,
            "/" => right / left,
            _ => 0
        };
    }
}
