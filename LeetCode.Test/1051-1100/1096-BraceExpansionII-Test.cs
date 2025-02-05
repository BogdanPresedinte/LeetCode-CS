﻿namespace LeetCode.Test
{
    public class _1096_BraceExpansionII_Test
    {
        [Test]
        public void BraceExpansionIITest_1() {
            var solution = new _1096_BraceExpansionII();
            var results = solution.BraceExpansionII("{a,b}{c,{d,e}}");
            AssertHelper.AssertList(new string[] { "ac", "ad", "ae", "bc", "bd", "be" }, results);
        }

        [Test]
        public void BraceExpansionIITest_2() {
            var solution = new _1096_BraceExpansionII();
            var results = solution.BraceExpansionII("{{a,z},a{b,c},{ab,z}}");
            AssertHelper.AssertList(new string[] { "a", "ab", "ac", "z" }, results);
        }
    }
}
