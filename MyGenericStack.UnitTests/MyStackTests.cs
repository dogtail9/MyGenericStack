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

        [TestMethod]
        public void PopItemFromTheStack()
        {
            // Arrange
            var expectedCount = 0;
            var item = "Hello World!";

            var stack = new MyStack<string>();
            stack.Push(item);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.AreEqual(item, result);
            Assert.AreEqual(expectedCount, stack.Count);
        }

        [TestMethod]
        public void PopSeveralItemsFromTheStack()
        {
            // Arrange
            var expectedCount = 0;
            var item1 = "Hello World!";
            var item2 = "Hello World Again!";

            var stack = new MyStack<string>();
            stack.Push(item1);
            stack.Push(item2);

            // Act
            var result1 = stack.Pop();
            var result2 = stack.Pop();

            // Assert
            Assert.AreEqual(item1, result2);
            Assert.AreEqual(item2, result1);
            Assert.AreEqual(expectedCount, stack.Count);
        }

        [TestMethod]
        public void PeekMessage()
        {
            // Arrange
            var expectedCount = 1;
            var item = "Hello World!";

            var stack = new MyStack<string>();
            stack.Push(item);

            // Act
            var value = stack.Peek();

            // Assert
            Assert.AreEqual(item, value);
            Assert.AreEqual(expectedCount, stack.Count);
        }
    }
}