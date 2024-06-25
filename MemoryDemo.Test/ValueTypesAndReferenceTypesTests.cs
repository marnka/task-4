using Xunit;

namespace MemoryDemo.Tests
{
    public class ValueTypesAndReferenceTypesTests
    {
        [Fact]
        public void TestValueTypes()
        {
            var a = 10;
            var b = a;
            b++;
            Assert.Equal(10, a); // a не змінюється

            var struct1 = new CustomStruct { Value = 10 };
            var struct2 = struct1;
            struct2.Value++;
            Assert.Equal(10, struct1.Value); // struct1 не змінюється
        }

        [Fact]
        public void TestReferenceTypes()
        {
            var class1 = new CustomClass { Value = 10 };
            var class2 = class1;
            class2.Value++;
            Assert.Equal(11, class1.Value); // class1 змінюється
        }
    }
}
