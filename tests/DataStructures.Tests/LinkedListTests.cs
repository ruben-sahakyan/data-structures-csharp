using Xunit;
using DataStructures.Collections;

namespace DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void AddLast_OnEmptyList_AddsElement()
        {
            var list = new LinkedList();

            Assert.Equal(0, list.Count);
            Assert.Equal(
                new string[] {},
                list.ToArray()
            );

            list.AddLast("test1");
            Assert.Equal(1, list.Count);
            Assert.Equal(
                new string[] {"test1"},
                list.ToArray()
            );
        }
        [Fact]
        public void AddLast_OnNonEmptyList_AddsElementToEnd()
        {
            var list = new LinkedList();

            list.AddLast("test1");
            list.AddLast("test2");
            list.AddLast("test3");
            Assert.Equal(3, list.Count);
            Assert.Equal(
                new string[] {"test1", "test2", "test3"},
                list.ToArray()
            );
        }
        [Fact]
        public void RemoveLast_OnEmptyList_DoesNothing()
        {
            var list = new LinkedList();
            list.RemoveLast();
            Assert.Equal(0, list.Count);
            Assert.Equal(
                new string[] {},
                list.ToArray()
            );
        }
        [Fact]
        public void RemoveLast_OnSingleElementList_RemovesElement()
        {
            var list = new LinkedList();
            
            list.AddLast("test1");
            list.RemoveLast();
            Assert.Equal(0, list.Count);
            Assert.Equal(
                new string[] {},
                list.ToArray()
            );
        }
        [Fact]
        public void RemoveLast_OnMultipleElements_RemovesLastElement()
        {
            var list = new LinkedList();

            list.AddLast("test1");
            list.AddLast("test2");
            list.AddLast("test3");
            list.AddLast("test4");

            list.RemoveLast();
            Assert.Equal(3, list.Count);
            Assert.Equal(
                new string[] {"test1", "test2", "test3"},
                list.ToArray()
            );
        }
    }
}
