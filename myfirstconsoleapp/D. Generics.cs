// generic method ==> type as a arguments
using System;

class Generic
{
    public T Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
        return value;
    }
}