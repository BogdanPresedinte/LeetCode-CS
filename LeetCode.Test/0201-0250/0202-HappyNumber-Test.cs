namespace LeetCode.Test
{
    public class _0202_HappyNumber_Test
    {
        [Test]
        public void IsHappyTest() {
            var solution = new _0202_HappyNumber();
            var result = solution.IsHappy(19);
            Assert.IsTrue(result);
        }
    }
}
