namespace LeetCode.Test
{
    public class _1055_ShortestWaytoFormString_Test
    {
        [Test]
        public void ShortestWayTest_1() {
            var solution = new _1055_ShortestWaytoFormString();
            var result = solution.ShortestWay("abc", "abcbc");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ShortestWayTest_2() {
            var solution = new _1055_ShortestWaytoFormString();
            var result = solution.ShortestWay("abc", "acdbc");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void ShortestWayTest_3() {
            var solution = new _1055_ShortestWaytoFormString();
            var result = solution.ShortestWay("xyz", "xzyxz");
            Assert.AreEqual(3, result);
        }
    }
}
