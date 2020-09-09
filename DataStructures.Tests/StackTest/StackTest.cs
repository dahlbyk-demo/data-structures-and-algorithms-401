﻿using System;
using DataStructures.Stack;
using Xunit;

namespace DataStructures.Tests.StackTest
{
    public class StackTest
    {
        [Fact]
        public void IsEmpty_returns_true_if_stack_is_empty()
        {
            // Arrange 
            Stack<int> stack = new Stack<int>();

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void IsEmpty_returns_false_if_stack_is_not_empty()
        {
            // Arrange 
            Stack<int> stack = new Stack<int>();
            stack.Push(1);

            // Act
            bool result = stack.IsEmpty();

            // Assert
            Assert.False(result);

        }

        [Fact]
        public void Push_adds_to_stack()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();

            // Act
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            // Assert
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Pop_removes_top_of_stack_and_returns_value()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            //Act
            int result = stack.Pop();

            //Assert
            Assert.Equal(2, stack.Peek());
            Assert.Equal(1, result);
        }

        [Fact]
        public void Error_throws_if_pop_empty_stack()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                return stack.Pop();
            });
        }

        [Fact]
        public void Pop_more_than_one()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            //Act
            int result = stack.Pop();
            int result2 = stack.Pop();
            int result3 = stack.Pop();

            //Assert
            Assert.Equal(1, result);
            Assert.Equal(2, result2);
            Assert.Equal(3, result3);

            bool boolResult = stack.IsEmpty();

            Assert.True(boolResult);
        }

        [Fact]
        public void Peek_on_empty_stack()
        {
            Stack<int> stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                return stack.Peek();
            });
        }
    }

    public class QueueTest
    {
        [Fact]
        public void QIsEmpty_returns_true_if_queue_is_empty()
        {
            // Arrange 
            Queue<int> queue = new Queue<int>();

            // Act
            bool result = queue.QIsEmpty();

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void QIsEmpty_returns_false_if_queue_is_not_empty()
        {
            // Arrange 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            // Act
            bool result = queue.QIsEmpty();

            // Assert
            Assert.False(result);

        }

        //[Fact]
        //public void Dequeue_takes_off_front_node()
        //{
        //    Queue<int> queue = new Queue<int>();
        //    queue.Enqueue(1);
        //    queue.Enqueue(2);
        //    queue.Enqueue(3);

        //    int result = queue.Dequeue();


        //    Assert.Equal(1, result);
        //}

        [Fact]
        public void Peek_look_at_front_value()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int result = queue.QPeek();

            Assert.Equal(1, result);
        }

        //[Fact]
        //public void Error_throws_if_Dequeue_on_empty_queue()
        //{
        //    Queue<int> queue = new Queue<int>();

        //    Assert.Throws<InvalidOperationException>(() =>
        //    {
        //        //Act
        //        return queue.Dequeue();
        //    });
        //}

        [Fact]
        public void QPeek_on_empty_queue()
        {
            Queue<int> queue = new Queue<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                //Act
                return queue.QPeek();
            });

        }
    }
}
