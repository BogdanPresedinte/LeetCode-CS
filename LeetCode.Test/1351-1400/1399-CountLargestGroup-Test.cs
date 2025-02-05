namespace LeetCode.Test
{
    public class _1399_CountLargestGroup_Test
    {
        [Test]
        public void CountLargestGroup_1() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(13);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CountLargestGroup_2() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(2);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CountLargestGroup_3() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(15);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void CountLargestGroup_4() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(24);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CountLargestGroup_5() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(100);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CountLargestGroup_6() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(105);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CountLargestGroup_7() {
            var solution = new _1399_CountLargestGroup();
            var result = solution.CountLargestGroup(1000);
            Assert.AreEqual(2, result);
        }
    }
}
