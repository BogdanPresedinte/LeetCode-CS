namespace LeetCode.Test
{
    public class _0841_KeysAndRooms_Test
    {
        [Test]
        public void CanVisitAllRooms_1() {
            var solution = new _0841_KeysAndRooms();
            var result = solution.CanVisitAllRooms(new List<IList<int>> {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { },
            });
            Assert.IsTrue(result);
        }

        [Test]
        public void CanVisitAllRooms_2() {
            var solution = new _0841_KeysAndRooms();
            var result = solution.CanVisitAllRooms(new List<IList<int>> {
                new int[] { 1, 3 },
                new int[] { 3, 0, 1 },
                new int[] { 2 },
                new int[] { 0, },
            });
            Assert.IsFalse(result);
        }
    }
}
