namespace LeetCode.Test
{
    public class _0225_ImplementStackUsingQueues_Test
    {
        [Test]
        public void ImplementStackUsingQueues_1() {
            var solution = new _0225_ImplementStackUsingQueues();
            solution.Push(1);
            solution.Push(2);
            Assert.AreEqual(2, solution.Top());
            Assert.AreEqual(2, solution.Pop());
            Assert.IsFalse(solution.Empty());
        }
    }
}
