using System;
using System.Collections;
using System.Collections.Generic;

public class RandomList : ArrayList
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString(List<string> data)
    {
        var element = rnd.Next(0, data.Count - 1);
        var str = data[element];
        data.Remove(str);
        return str;
    }
}

