using System;
using NUnit.Framework;
using MyListProgram;

namespace MyListTests
{
    public class Tests
    {
        [TestCaseSource("source1")]
        [TestCaseSource("source2")]
        public void Add_WhenCalled_ShouldAddElementToZeroIndex(IList sourceArray, IList expectedArray, int value)
        {
            sourceArray.Add(value);
            Assert.AreEqual(sourceArray.Count, expectedArray.Count);
            for (int i = 0; i < sourceArray.Count; i++)
            {
                Assert.AreEqual(sourceArray[i], expectedArray[i]);
            }
        }

        [TestCase(-1)]
        [TestCase(2)]
        public void AddByIndex_WhenIndexLessThenZero_ShouldThrowArgumentException(int index)
        {
            try
            {
                IList vs = new MyList();
                vs.AddByIndex(10, index);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "Index bigger than size array or index <0");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource("source3")]
        [TestCaseSource("source4")]
        public void AddByIndex_WhenCalled_ShouldAddElement(IList sourceArray, IList expectedArray, int value, int index)
        {
            sourceArray.AddByIndex(value, index);
            Assert.AreEqual(sourceArray.Count, expectedArray.Count);
            for (int i = 0; i < sourceArray.Count; i++)
            {
                Assert.AreEqual(sourceArray[i], expectedArray[i]);
            }
        }

        [TestCaseSource("source5")]
        public void ChangeValueByIndex_WhenCalled_ShouldChangeElement(IList sourceArray, IList expectedArray, int value, int index)
        {
            sourceArray.ChangeValueByIndex(value, index);
            Assert.AreEqual(sourceArray.Count, expectedArray.Count);
            for (int i = 0; i < sourceArray.Count; i++)
            {
                Assert.AreEqual(sourceArray[i], expectedArray[i]);
            }
        }

        [Test]
        public void ChangeValueByIndex_WhenArrayIsEmpty_ShouldThrowArgumentException()
        {
            try
            {
                IList vs = new MyList();
                vs.ChangeValueByIndex(10, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "Index bigger than size array");
                Assert.Pass();
            }
            Assert.Fail();
        }

        private static object[] source1 = new[]
{
            new object[]
            {
                new MyList() { 1, 2, 3}, new MyList() { 1, 2, 3, 4 }, 4
            }
        };

        private static object[] source2 = new[]
        {
            new object[]
            {
                new MyList(), new MyList() { 4 }, 4
            }
        };

        private static object[] source3 = new[]
        {
            new object[]
            {
                new MyList() { 1, 2, 3}, new MyList() { 1, 5, 2, 3}, 5, 1
            }
        };

        private static object[] source4 = new[]
        {
            new object[]
            {
                new MyList() { 1, 2, 3, 4, 5}, new MyList() { 1, 2, 3, 6, 4, 5}, 6, 3
            }
        };

        private static object[] source5 = new[]
        {
            new object[]
            {
                new MyList() { 1, 2, 3}, new MyList() { 1, 5, 3}, 5, 1
            }
        };
    }
}