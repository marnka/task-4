using System;

namespace MemoryDemo
{
    public class GarbageCollectorDemo
    {
        public static void CreateObject()
        {
            var obj = new CustomClass { Value = 100 };
            Console.WriteLine($"Object created with value: {obj.Value}");
        }
    }
}
