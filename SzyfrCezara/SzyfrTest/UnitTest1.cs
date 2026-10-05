using SzyfrCezara;

namespace SzyfrTest
{
    [TestClass]
    public class SzyfrTest
    {
        [TestMethod]
        public void ReturnsAppropriateString()
        {
            String text = "abc";
            int key = 3;
            var encrypter = new CaesarCipher(text, key);

            var actualResult = encrypter.encrypt();
            var expectedResult = "def";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnsAppropriateStringWithOverflowingKey()
        {
            String text = "xyz";
            int key = 3;
            var encrypter = new CaesarCipher(text, key);

            var actualResult = encrypter.encrypt();
            var expectedResult = "abc";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnsAppropriateStringWithNegativeKey() 
        {
            String text = "def";
            int key = -3;
            var encrypter = new CaesarCipher(text, key);

            var actualResult = encrypter.encrypt();
            var expectedResult = "abc";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnsAppropriateStringWithKeyLargerThanTheAlphabet()
        {
            String text = "abc";
            int key = 29;
            var encrypter = new CaesarCipher(text, key);

            var actualResult = encrypter.encrypt();
            var expectedResult = "def";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnsAppropriateStringWithSpaces()
        {
            String text = "ab cd";
            int key = 2;
            var encrypter = new CaesarCipher(text, key);

            var actualResult = encrypter.encrypt();
            var expectedResult = "cd ef";

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}