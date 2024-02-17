namespace LeetCode.Test
{
    public class _0588_DesignInMemoryFileSystem_Test
    {
        [Test]
        public void DesignInMemoryFileSystem_1() {
            var solution = new _0588_DesignInMemoryFileSystem();
            Assert.AreEqual(0, solution.Ls("/").Count);
            solution.Mkdir("/a/b/c");
            solution.AddContentToFile("/a/b/c", "Hello");
            var list = solution.Ls("/");
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("a", list[0]);

            Assert.AreEqual("Hello", solution.ReadContentFromFile("/a/b/c/d"));
        }
    }
}
