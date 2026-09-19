public class MinStack {

    private Stack<int> stack;
    
    public MinStack()
    {
        stack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        var peek = stack.Peek();
        
        return peek;
    }

    public int GetMin()
    {
        var tmp = new Stack<int>();
        var min = stack.Peek();

        while (stack.Count > 0)
        {
            min = Math.Min(min, stack.Peek());
            tmp.Push(stack.Pop());
        }

        while (tmp.Count > 0)
        {
            stack.Push(tmp.Pop());
        }
        
        return min;
    }
}
