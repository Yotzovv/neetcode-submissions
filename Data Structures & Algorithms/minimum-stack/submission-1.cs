public class MinStack
{
    private List<int> _stack;
    
    public MinStack()
    {
        _stack = new List<int>();
    }
    
    public void Push(int val) {
        _stack.Insert(0, val);
    }
    
    public void Pop() {
        _stack.RemoveAt(0);
    }
    
    public int Top()
    {
        return _stack.ElementAt(0);
    }
    
    public int GetMin()
    {
        var min = int.MaxValue;

        for (int i = 0; i < _stack.Count; i++)
        {
            if(_stack[i] < min) min = _stack[i];
        }

        return min;
    }
}