using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyGenericStack.UnitTests
{
    [TestClass]
    public class MyStackTests
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

        [TestMethod]
        public void PushStringToStack()
        {
            // Arrange
            var expected = 1;
            var stack = new MyStack<string>();

            // Act
            stack.Push("Hello World!");

            // Assert
            Assert.AreEqual(expected, stack.Count);
        }
    }
}