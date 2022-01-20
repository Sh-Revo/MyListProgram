using System;
using NUnit.Framework;
using MyListProgram;

namespace MyListTests
{
    public class TestDelete
    {
        [TestCase(-1)]
        [TestCase(2)]
        public void DeleteByIndex_WhenIndexLessThenZero_ShouldThrowArgumentException(int index)
        {
            try
            {
                IList vs = new MyList();
                vs.DeleteByIndex(index);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "Index bigger than size array or index <0");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void DeleteByIndex_WhenArrayIsEmpty_ShouldThrowArgumentException()
        {
            try
            {
                IList vs = new MyList();
                vs.DeleteByIndex(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.Message, "Array is empty");
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
