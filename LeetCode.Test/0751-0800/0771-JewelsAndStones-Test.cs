namespace LeetCode.Test
{
    public class _0771_JewelsAndStones_Test
    {
        [Test]
        public void NumJewelsInStonesTest_1() {
            var solution = new _0771_JewelsAndStones();
            var result = solution.NumJewelsInStones("aA", "aAAbbbb");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void NumJewelsInStonesTest_2() {
            var solution = new _0771_JewelsAndStones();
            var result = solution.NumJewelsInStones("z", "ZZ");
            Assert.AreEqual(0, result);
        }
    }
}
