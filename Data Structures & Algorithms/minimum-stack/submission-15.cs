public class MinStack { 
    // Input: ["MinStack", "push", 1, "push", 2, "push", 0, "getMin", "pop", "top", "getMin"]
    // Output: [null,null,null,null,0,null,2,1]
    // current minStack: [1,0]      min=1 top=2
    private long min;
    private Stack<long> stack;
    
    public MinStack()
    {
        stack = new Stack<long>();
    }

    public void Push(int val)
    {
        if (stack.Count == 0)
        {
            stack.Push(0L);
            min = val;
        }
        else
        {
            stack.Push(val - min);
            if (val < min) min = val;
        }
    }

    public void Pop()
    {
        if (stack.Count == 0) return;
        
        var pop = stack.Pop();
        if (pop < 0) min -= pop;
    }

    public int Top()
    {
        var top = stack.Peek();
        return top > 0 ? (int)(top + min) : (int)min;
    }

    public int GetMin()
    {
        return (int)min;
    }
}
