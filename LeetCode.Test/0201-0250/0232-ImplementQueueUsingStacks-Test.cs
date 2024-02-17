namespace LeetCode.Test
{
    public class _0232_ImplementQueueUsingStacks_Test
    {
        [Test]
        public void ImplementQueueUsingStacks_1() {
            var solution = new _0232_ImplementQueueUsingStacks();
            solution.Push(1);
            solution.Push(2);
            Assert.AreEqual(1, solution.Peek());
            Assert.AreEqual(1, solution.Pop());
            Assert.IsFalse(solution.Empty());
        }
    }
}
