namespace LeetCode.Test
{
    public class _0269_AlienDictionary_Test
    {
        [Test]
        public void AlienOrderTest_1() {
            var solution = new _0269_AlienDictionary();
            var result = solution.AlienOrder(new string[] { "wrt", "wrf", "er", "ett", "rftt" });
            Assert.AreEqual("wertf", result);
        }

        [Test]
        public void AlienOrderTest_2() {
            var solution = new _0269_AlienDictionary();
            var result = solution.AlienOrder(new string[] { "z", "x" });
            Assert.AreEqual("zx", result);
        }

        [Test]
        public void AlienOrderTest_3() {
            var solution = new _0269_AlienDictionary();
            var result = solution.AlienOrder(new string[] { "z", "x", "z" });
            Assert.AreEqual("", result);
        }

        [Test]
        public void AlienOrderTest_4() {
            var solution = new _0269_AlienDictionary();
            var result = solution.AlienOrder(new string[] { "wx", "we", "e", "a" });
            Assert.AreEqual("xwea", result);
        }

        [Test]
        public void AlienOrderTest_5() {
            var solution = new _0269_AlienDictionary();
            var result = solution.AlienOrder(new string[] { "abc", "ab" });
            Assert.AreEqual("", result);
        }
    }
}
