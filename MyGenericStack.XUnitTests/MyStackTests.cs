using System;
using System.Collections.Generic;
using Xunit;

namespace MyGenericStack.XUnitTests
{
    public class MyStackTests
    {
        [Fact]
        public void CreateStack()
        {
            // Arrange
            var expected = typeof(MyStack<string>);

            // Act
            var stack = new MyStack<string>();

            // Assert
            Assert.IsType(expected, stack);
        }

        [Fact]
        public void PushStringToStack()
        {
            // Arrange
            var expected = 1;
            var stack = new MyStack<string>();

            // Act
            stack.Push("Hello World!");

            // Assert
            Assert.Equal(expected, stack.Count);
        }

        [Fact]
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
            Assert.Equal(expected, stack.Count);
        }

        [Fact]
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
            Assert.Equal(item, result);
            Assert.Equal(expectedCount, stack.Count);
        }

        [Fact]
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
            Assert.Equal(item1, result2);
            Assert.Equal(item2, result1);
            Assert.Equal(expectedCount, stack.Count);
        }

        [Fact]
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
            Assert.Equal(item, value);
            Assert.Equal(expectedCount, stack.Count);
        }

        [Fact]
        public void PeekEmptyStack()
        {
            // Arrange
            var stack = new MyStack<string>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                stack.Peek();
            });
        }

        [Fact]
        public void PopEmptyStack()
        {
            // Arrange
            var stack = new MyStack<string>();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                stack.Pop();
            });
        }

        [Fact]
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
            Assert.Equal(1, count);

            // Pop the stack
            string itemPop = stack.Pop();

            // The peek and pop item should be the same object
            Assert.Equal(itemPeek, itemPop);

            // There should not be any items in the stack
            Assert.Empty(stack);

            // If we pop an empty stack it will throw
            Assert.Throws<InvalidOperationException>(() =>
            {
                // Act
                stack.Pop();
            });
        }
    }
}