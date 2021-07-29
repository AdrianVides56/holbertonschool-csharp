using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FirstUniqueChar([Values("hello", "true")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void NoUniqueChar([Values("tddt", "hhoommee")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void LastIsUniqueChar([Values("soosy")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 4);
        }

        [Test]
        public void EmptyString([Values("")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void OneLengthString([Values(" ", "\"", "t")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void MiddleUniqueChar([Values("aabbccdffeegg")] string s)
        {
            int result = Str.UniqueChar(s);
            Assert.AreEqual(result, 6);
        }
    }
}