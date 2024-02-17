namespace LeetCode.Test
{
    public class _0155_MinStack_Test
    {
        [Test]
        public void MinStackTest() {
            _0155_MinStack minStack = new _0155_MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            var result = minStack.GetMin();
            Assert.AreEqual(-3, result);

            minStack.Pop();
            result = minStack.Top();
            Assert.AreEqual(0, result);

            result = minStack.GetMin();
            Assert.AreEqual(-2, result);
        }
    }
}
