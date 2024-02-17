namespace LeetCode.Test
{
    public class _0422_ValidWordSquare_Test
    {
        [Test]
        public void ValidWordSquare_1() {
            var solution = new _0422_ValidWordSquare();
            var result = solution.ValidWordSquare(new List<string>()
            {
                "abcd",
                "bnrt",
                "crmy",
                "dtye"
            });
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidWordSquare_2() {
            var solution = new _0422_ValidWordSquare();
            var result = solution.ValidWordSquare(new List<string>()
            {
                "abcd",
                "bnrt",
                "crm",
                "dt"
            });
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidWordSquare_3() {
            var solution = new _0422_ValidWordSquare();
            var result = solution.ValidWordSquare(new List<string>()
            {
                "ball",
                "area",
                "read",
                "lady"
            });
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidWordSquare_4() {
            var solution = new _0422_ValidWordSquare();
            var result = solution.ValidWordSquare(new List<string>()
            {
                "ball",
                "asee",
                "let",
                "lep"
            });
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidWordSquare_5() {
            var solution = new _0422_ValidWordSquare();
            var result = solution.ValidWordSquare(new List<string>()
            {
                "abc",
                "b"
            });
            Assert.IsFalse(result);
        }
    }
}
