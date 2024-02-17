using static LeetCode._0702_SearchInASortedArrayOfUnknownSize;

namespace LeetCode.Test
{
    public class _0702_SearchInASortedArrayOfUnknownSize_Test
    {
        [Test]
        public void SearchTest_1() {
            var solution = new _0702_SearchInASortedArrayOfUnknownSize();
            var result = solution.Search(new ArrayReader(new int[] { -1, 0, 3, 5, 9, 12 }), 9);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void SearchTest_1_2() {
            var solution = new _0702_SearchInASortedArrayOfUnknownSize();
            var result = solution.Search(new ArrayReader(new int[] { -1, 0, 3, 5, 9, 12 }), 2);
            Assert.AreEqual(-1, result);
        }
    }
}
