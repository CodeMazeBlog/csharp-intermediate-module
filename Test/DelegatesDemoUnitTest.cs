using DelegatesDemo.Delegates;
using DelegatesDemo.Interfaces;
using NUnit.Framework;

namespace DelegatesDemo.Test
{
    [TestFixture]
    public class DelegateDemoTest
    {
        [Test]
        public void Test_ReverseStringDelegate()
        {
            // Arrange
            IFunctionDelegate<string, string> reverseStringDelegate = new FunctionDelegate<string, string>(ReverseString);

            // Act
            string reversedName = reverseStringDelegate.Execute("Developer");

            // Assert
            Assert.AreEqual("itrA", reversedName);
        }

        string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
