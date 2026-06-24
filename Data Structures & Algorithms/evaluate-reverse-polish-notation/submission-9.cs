
public class Solution {
    public int EvalRPN(string[] tokens)
    {
        // var stack = GetStack(tokens);
        var result = new Stack<int>();

        for(var i = 0; i < tokens.Length; i++)
        {
            
            if(int.TryParse(tokens[i], out var number)) result.Push(number);
            if(IsSymbol(tokens[i])) Operate(result, tokens[i][0]);
        }
        
        return result.Pop();
    }

    public void Operate(Stack<int> stack, char token)
    {
        int right = stack.Pop();
        int left = stack.Pop();
        int currentResult = 0;

        if (token == '+') currentResult = left+right;
        else if (token == '-') currentResult = left - right;
        else if (token == '*') currentResult =  left * right;
        else if (token == '/') currentResult =  left / right;

        stack.Push(currentResult);
    }

    public bool IsSymbol(string token) =>
        token == "+" || token == "-" || token == "*" || token == "/";
}