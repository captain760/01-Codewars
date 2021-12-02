using System;
using System.Collections.Generic;

    public sealed class DictionaryMerger
    {
        public static Dictionary<TKey, TValue[]> Merge<TKey, TValue>(params Dictionary<TKey, TValue>[] dicts)
        {
            
        return new Dictionary<TKey, TValue[]>();
        }
    }

namespace _19.Dictionary_Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var original1 = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            var original2 = new Dictionary<string, int> { { "A", 4 }, { "D", 5 } };
            var merged = DictionaryMerger.Merge(original1, original2);
        }
    }
}
