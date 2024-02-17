namespace LeetCode.Test
{
    public class _0547_FriendCircles_Test
    {
        [Test]
        public void FindCircleNum_1() {
            var solution = new _0547_FriendCircles();
            var result = solution.FindCircleNum(new int[][] {
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 0, 1 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void FindCircleNum_2() {
            var solution = new _0547_FriendCircles();
            var result = solution.FindCircleNum(new int[][] {
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 1 },
            });
            Assert.AreEqual(1, result);
        }
    }
}
