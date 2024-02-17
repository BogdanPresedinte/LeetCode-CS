namespace LeetCode.Test
{
    public class _1134_ArmstrongNumber_Test
    {
        [Test]
        public void IsArmstrong_1() {
            var solution = new _1134_ArmstrongNumber();
            var result = solution.IsArmstrong(153);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsArmstrong_2() {
            var solution = new _1134_ArmstrongNumber();
            var result = solution.IsArmstrong(123);
            Assert.IsFalse(result);
        }
    }
}
