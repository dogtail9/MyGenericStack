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

        [TestMethod]
        public void PushSeveralItemsToTheStack()
        {
            // Arrange
            var expected = 2;
            var item1 = "Hello World!";
            var item2 = "Hello World Again!";
            var stack = new MyStack<string>();

            // Act
            stack.Push(item1);
            stack.Push(item2);

            // Assert
            Assert.AreEqual(expected, stack.Count);
        }
    }
}