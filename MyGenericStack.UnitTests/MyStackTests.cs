using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void PeekEmptyStack()
        {
            // Arrange
            var stack = new MyStack<string>();

            // Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                // Act
                stack.Peek();
            });
        }

        [TestMethod]
        public void PopEmptyStack()
        {
            // Arrange
            var stack = new MyStack<string>();

            // Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                // Act
                stack.Pop();
            });
        }

        [TestMethod]
        public void TestBuiltInStack()
        {
            // Create a stack
            Stack<string> stack = new Stack<string>();

            // Push an item to the stack
            stack.Push("Hello World!");

            // Peek the stack
            string itemPeek = stack.Peek();

            // Get the number od items in the stack
            int count = stack.Count;
            
            // The number of items in the stack should be 1
            Assert.AreEqual(1, count);

            // Pop the stack
            string itemPop = stack.Pop();

            // The peek and pop item should be the same object
            Assert.AreEqual(itemPeek, itemPop);

            // There should not be any items in the stack
            Assert.AreEqual(0, stack.Count);

            // If we pop an empty stack it will throw
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                // Act
                stack.Pop();
            });
        }
    }
}