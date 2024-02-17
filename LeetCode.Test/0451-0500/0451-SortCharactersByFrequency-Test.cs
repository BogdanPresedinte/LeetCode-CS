namespace LeetCode.Test
{
    public class _0451_SortCharactersByFrequency_Test
    {
        [Test]
        public void FrequencySort_1() {
            var solution = new _0451_SortCharactersByFrequency();
            var result = solution.FrequencySort("tree");
            Assert.AreEqual("eetr", result);
        }

        [Test]
        public void FrequencySort_2() {
            var solution = new _0451_SortCharactersByFrequency();
            var result = solution.FrequencySort("cccaaa");
            Assert.AreEqual("cccaaa", result);
        }

        [Test]
        public void FrequencySort_3() {
            var solution = new _0451_SortCharactersByFrequency();
            var result = solution.FrequencySort("Aabb");
            Assert.AreEqual("bbAa", result);
        }

        [Test]
        public void FrequencySort_4() {
            var solution = new _0451_SortCharactersByFrequency();
            var result = solution.FrequencySort("");
            Assert.AreEqual("", result);
        }
    }
}
