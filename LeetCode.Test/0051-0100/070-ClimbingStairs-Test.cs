namespace LeetCode.Test
{
    public class _070_ClimbingStairs_Test
    {
        [Test]
        public void ClimbStairs_Zero() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(0);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ClimbStairs_One() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(1);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ClimbStairs_Two() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(2);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ClimbStairs_Three() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(3);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void ClimbStairs_Four() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(4);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void ClimbStairs_Five() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(5);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void ClimbStairs_Six() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(6);

            Assert.AreEqual(13, result);
        }

        [Test]
        public void ClimbStairs_Seven() {
            var solution = new _070_ClimbingStairs();
            var result = solution.ClimbStairs(7);

            Assert.AreEqual(21, result);
        }
    }
}
