namespace LeetCode.Test
{
    public class _1286_IteratorForCombination_Test
    {
        [Test]
        public void IteratorForCombination_1() {
            _1286_IteratorForCombination iterator = new _1286_IteratorForCombination("abc", 2); // creates the iterator.
            Assert.AreEqual("ab", iterator.Next());
            Assert.IsTrue(iterator.HasNext());
            Assert.AreEqual("ac", iterator.Next());
            Assert.IsTrue(iterator.HasNext());
            Assert.AreEqual("bc", iterator.Next());
            Assert.IsFalse(iterator.HasNext());
        }
    }
}
