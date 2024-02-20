namespace LeetCode.Test
{
    public class _002_AddTwoNumbers_Test
    {
        [Test]
        public void AddTwoNumbersTest_General()
        {
            ListNode link = TestHelper.GenerateList([2, 4, 3]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList([4, 8, 6], result);
        }

        [Test]
        public void AddTwoNumbersTest_General_2()
        {
            ListNode link = TestHelper.GenerateList([0]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link, link);

            AssertHelper.AssertLinkList([0], result);
        }

        [Test]
        public void AddTwoNumbersTest_HasCarry()
        {
            ListNode link1 = TestHelper.GenerateList([2, 4, 3]);
            ListNode link2 = TestHelper.GenerateList([5, 6, 4]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([7, 0, 8], result);
        }

        [Test]
        public void AddTwoNumbersTest_HasMultipleCarry()
        {
            ListNode link1 = TestHelper.GenerateList([1]);
            ListNode link2 = TestHelper.GenerateList([9, 9]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([0, 0, 1], result);
        }

        [Test]
        public void AddTwoNumbersTest_FirstNumCarry()
        {
            ListNode link1 = TestHelper.GenerateList([3, 4, 4]);
            ListNode link2 = TestHelper.GenerateList([3, 4, 6]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([6, 8, 0, 1], result);
        }

        [Test]
        public void AddTwoNumbersTest_L1Longer()
        {
            ListNode link1 = TestHelper.GenerateList([2, 4, 3, 1]);
            ListNode link2 = TestHelper.GenerateList([5, 6, 4]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([7, 0, 8, 1], result);
        }

        [Test]
        public void AddTwoNumbersTest_L1Longer_2()
        {
            ListNode link1 = TestHelper.GenerateList([1, 8]);
            ListNode link2 = TestHelper.GenerateList([0]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([1, 8], result);
        }

        [Test]
        public void AddTwoNumbersTest_L1Empty()
        {
            ListNode link1 = TestHelper.GenerateList(null);
            ListNode link2 = TestHelper.GenerateList([1, 8]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([1, 8], result);
        }

        [Test]
        public void AddTwoNumbersTest_L2Longer()
        {
            ListNode link1 = TestHelper.GenerateList([2, 4, 3]);
            ListNode link2 = TestHelper.GenerateList([5, 6, 4, 3]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([7, 0, 8, 3], result);
        }

        [Test]
        public void AddTwoNumbersTest_L2Longer_2()
        {
            ListNode link1 = TestHelper.GenerateList([0]);
            ListNode link2 = TestHelper.GenerateList([1, 8]);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([1, 8], result);
        }

        [Test]
        public void AddTwoNumbersTest_L2Empty()
        {
            ListNode link1 = TestHelper.GenerateList([1, 8]);
            ListNode link2 = TestHelper.GenerateList(null);

            _002_AddTwoNumbers solution = new _002_AddTwoNumbers();
            ListNode result = solution.AddTwoNumbers(link1, link2);

            AssertHelper.AssertLinkList([1, 8], result);
        }
    }
}
