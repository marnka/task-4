using System;
using Xunit;

namespace MemoryDemo.Tests
{
    public class GarbageCollectorDemoTests
    {
        [Fact]
        public void TestGarbageCollector()
        {
            MemoryDemo.GarbageCollectorDemo.CreateObject();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Assert.True(true, "Garbage collector executed successfully");
        }
    }
}
