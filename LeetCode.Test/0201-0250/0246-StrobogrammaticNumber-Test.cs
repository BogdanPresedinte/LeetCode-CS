namespace LeetCode.Test
{
    public class _0246_StrobogrammaticNumber_Test
    {
        [Test]
        public void IsStrobogrammatic_1() {
            var solution = new _0246_StrobogrammaticNumber();
            var result = solution.IsStrobogrammatic("69");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsStrobogrammatic_2() {
            var solution = new _0246_StrobogrammaticNumber();
            var result = solution.IsStrobogrammatic("88");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsStrobogrammatic_3() {
            var solution = new _0246_StrobogrammaticNumber();
            var result = solution.IsStrobogrammatic("962");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsStrobogrammatic_4() {
            var solution = new _0246_StrobogrammaticNumber();
            var result = solution.IsStrobogrammatic("2");
            Assert.IsFalse(result);
        }
    }
}
