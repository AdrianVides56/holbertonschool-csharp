using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void RegularString([Values("level", "racecar")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void CaseSensitiveString([Values("Level", "racecaR")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void StringWithPunctuation([Values("A man, a plan, a canal: Panama.")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void EmptyString([Values("")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void NotPalindrome([Values("This", "is", "not", "palindrome")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, false);
        }

        [Test]
        public void StringWithQuotes([Values("\"\"")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void OneLengthString([Values(" ", "t")] string s)
        {
            bool result = Str.IsPalindrome(s);
            Assert.AreEqual(result, true);
        }
    }
}