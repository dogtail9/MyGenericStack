using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyGenericStack.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateStack()
        {
            // Arrange
            var expected = typeof(MyStack<string>);

            // Act
            var stack = new MyStack<string>();

            // Assert
            Assert.IsInstanceOfType(stack, expected);
        }
    }
}