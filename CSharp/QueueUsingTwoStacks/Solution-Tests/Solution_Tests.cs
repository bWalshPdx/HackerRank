using System;
using System.Collections.Generic;
using FluentAssertions;
using QueueUsingTwoStacks;
using Xunit;

namespace Solution_Tests
{
    public class Solution_Tests
    {
        [Fact]
        public void Initialize_GivenARecievedValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            Custom_Queue queue = new Custom_Queue(testValue);

            string value = queue.Dequeue();

            value.Should().BeEquivalentTo(testValue);
        }

        [Fact]
        public void Enqueue_GivenARecievedValue_ShouldAddValueToTheStack()
        {
            string testValue = "0";

            Custom_Queue queue = new Custom_Queue();

            queue.Enqueue(testValue);

            string value = queue.Dequeue();

            value.Should().BeEquivalentTo(testValue);
        }

        [Fact]
        public void Dequeue_GivenAValueCollection_ShouldReturnTheCorrectValues()
        {
            List<string> testValues = new List<string>(){"2", "3", "4"};
 
            Custom_Queue queue = new Custom_Queue();


            foreach (var value in testValues)
            {
               queue.Enqueue(value); 
            }

            List<string> output = new List<string>();

            foreach (var value in testValues)
            {
                string returnedValue = queue.Dequeue();

                output.Add(returnedValue);
            }

            output.Should().BeEquivalentTo(new List<string>(){"4", "3", "2"});
        }
    }
}