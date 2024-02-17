namespace LeetCode.Test
{
    public class _0735_AsteroidCollision_Test
    {
        [Test]
        public void AsteroidCollision_1() {
            var solution = new _0735_AsteroidCollision();
            var result = solution.AsteroidCollision(new int[] { 5, 10, -5 });
            AssertHelper.AssertArray(new int[] { 5, 10 }, result);
        }

        [Test]
        public void AsteroidCollision_2() {
            var solution = new _0735_AsteroidCollision();
            var result = solution.AsteroidCollision(new int[] { 8, -8 });
            AssertHelper.AssertArray(new int[] { }, result);
        }

        [Test]
        public void AsteroidCollision_3() {
            var solution = new _0735_AsteroidCollision();
            var result = solution.AsteroidCollision(new int[] { 10, 2, -5 });
            AssertHelper.AssertArray(new int[] { 10 }, result);
        }

        [Test]
        public void AsteroidCollision_4() {
            var solution = new _0735_AsteroidCollision();
            var result = solution.AsteroidCollision(new int[] { -2, -1, 1, 2 });
            AssertHelper.AssertArray(new int[] { -2, -1, 1, 2 }, result);
        }

        [Test]
        public void AsteroidCollision_5() {
            var solution = new _0735_AsteroidCollision();
            var result = solution.AsteroidCollision(new int[] { -2, -2, 1, -2 });
            AssertHelper.AssertArray(new int[] { -2, -2, -2 }, result);
        }
    }
}
