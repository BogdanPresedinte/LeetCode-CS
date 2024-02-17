namespace LeetCode.Test
{
    public class _0706_DesignHashmap_Test
    {
        [Test]
        public void MyHashMap_1() {
            var hashMap = new _0706_DesignHashmap();
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            Assert.AreEqual(1, hashMap.Get(1));
            Assert.AreEqual(-1, hashMap.Get(3));
            hashMap.Put(2, 1);
            Assert.AreEqual(1, hashMap.Get(2));
            hashMap.Remove(2);
            Assert.AreEqual(-1, hashMap.Get(2));
        }
    }
}
