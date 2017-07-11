using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        this.data.Add(item);
    }
    public string Pop()
    {
        var last = this.data.Last();
        this.data.Remove(last);
        return last;
    }
    public string Peek()
    {
        var last = this.data.Last();
        return last;
    }
    public bool IsEmpty()
    {
        if (data.Any())
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

