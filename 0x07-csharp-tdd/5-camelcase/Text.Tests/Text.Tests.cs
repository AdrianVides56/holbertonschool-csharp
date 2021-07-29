using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TwoWords([Values("oneTwo", "twoWords")] string s)
        {
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void OneWord([Values("one", "word", "u")] string s)
        {
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void ShortWords([Values("cDEFGAB", "lAArDiLlAH")] string s)
        {
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void NoWords([Values("", " ", "\"")] string s)
        {
            int result = Str.CamelCase(s);
            Assert.AreEqual(result, 0);
        }
    }
}