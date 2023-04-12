using System;
namespace STATIC;

public class MonCache : ICache
{
    private static List<string> data = new();
    public static void AddValue(string value)
    {
        data.Add(value);
    }

    public static IEnumerable<string> GetValues()
    {
        return data;
    }
}

public interface ICache
{
    static abstract IEnumerable<string> GetValues();
    static abstract void AddValue(string value);
}

