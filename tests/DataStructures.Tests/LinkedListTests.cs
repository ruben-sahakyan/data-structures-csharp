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
            Assert.Empty(list.ToArray());

            list.AddLast("node1");
            Assert.Equal(1, list.Count);
            Assert.Equal(
                new string[] {"node1"},
                list.ToArray()
            );
        }
        [Fact]
        public void AddLast_OnNonEmptyList_AddsElementToEnd()
        {
            var list = new LinkedList();

            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            Assert.Equal(3, list.Count);
            Assert.Equal(
                new string[] {"node1", "node2", "node3"},
                list.ToArray()
            );
        }
        [Fact]
        public void RemoveLast_OnEmptyList_DoesNothing()
        {
            var list = new LinkedList();
            list.RemoveLast();
            Assert.Equal(0, list.Count);
            Assert.Empty(list.ToArray());
        }
        [Fact]
        public void RemoveLast_OnSingleElementList_RemovesElement()
        {
            var list = new LinkedList();
            
            list.AddLast("node1");
            list.RemoveLast();
            Assert.Equal(0, list.Count);
            Assert.Empty(list.ToArray());
        }
        [Fact]
        public void RemoveLast_OnMultipleElements_RemovesLastElement()
        {
            var list = new LinkedList();

            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            list.AddLast("node4");

            list.RemoveLast();
            Assert.Equal(3, list.Count);
            Assert.Equal(
                new string[] {"node1", "node2", "node3"},
                list.ToArray()
            );
        }
        [Fact]
        public void AddFirst_OnEmptyList_AddsElement()
        {
            var list = new LinkedList();

            list.AddFirst("node1");
            Assert.Equal(1, list.Count);
            Assert.Equal(
                new string[] {"node1"},
                list.ToArray()
            );
        }
        [Fact]
        public void AddFirst_OnNonEmptyList_AddsElementToEnd()
        {
            var list = new LinkedList();

            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            list.AddFirst("node4");
            Assert.Equal(4, list.Count);
            Assert.Equal(
                new string[] {"node4", "node1", "node2", "node3"},
                list.ToArray()
            );
        }
        [Fact]
        public void RemoveFirst_OnEmptyList_DoesNothing()
        {
            var list = new LinkedList();

            list.RemoveFirst();
            Assert.Equal(0, list.Count);
            Assert.Empty(list.ToArray());
        }
        [Fact]
        public void RemoveFirst_OnSingleElementList_RemovesElement()
        {
            var list = new LinkedList();
            list.AddFirst("node1");

            list.RemoveFirst();
            Assert.Equal(0, list.Count);
            Assert.Empty(list.ToArray());
        }
        [Fact]
        public void RemoveFirst_OnMultipleElements_RemovesFirstElement()
        {
            var list = new LinkedList();
            list.AddFirst("node3");
            list.AddFirst("node2");
            list.AddFirst("node1");

            list.RemoveFirst();
            Assert.Equal(2, list.Count);
            Assert.Equal(
                new string[] {"node2", "node3"},
                list.ToArray()
            );
        }
        [Fact]
        public void Find_OnEmptyList_ReturnsNull()
        {
            var list = new LinkedList();
            var result = list.Find("node1");
            Assert.Null(result);
        }
        [Fact]
        public void Find_OnSingleElementList_WhenValueDoesNotMatch_ReturnsNull()
        {
            var list = new LinkedList();
            list.AddFirst("node1");
            var result = list.Find("node2");
            Assert.Null(result);
        }
        [Fact]
        public void Find_OnSingleElementList_WhenValueMatches_ReturnsValue()
        {
            var list = new LinkedList();
            list.AddFirst("node1");
            var result = list.Find("node1");
            Assert.Equal("node1", result);

        }
        [Fact]
        public void Find_OnMultipleElementList_WhenValueDoesNotMatch_ReturnsNull()
        {
            var list = new LinkedList();
            list.AddFirst("node3");
            list.AddFirst("node2");
            list.AddFirst("node1");
            var result = list.Find("node4");
            Assert.Null(result);
        }
        [Fact]
        public void Find_OnMultipleElementList_WhenValueMatches_ReturnsValue()
        {
            var list = new LinkedList();
            list.AddFirst("node3");
            list.AddFirst("node2");
            list.AddFirst("node1");
            var result = list.Find("node2");
            Assert.Equal("node2", result);
        }
        [Fact]
        public void FindLast_OnEmptyList_ReturnsNull()
        {
            var list = new LinkedList();
            var result = list.FindLast("node1");
            Assert.Null(result);
        }
        [Fact]
        public void FindLast_OnSingleElementList_WhenValueDoesNotMatch_ReturnsNull()
        {
            var list = new LinkedList();
            list.AddFirst("node1");
            var result = list.FindLast("node2");
            Assert.Null(result);
        }
        [Fact]
        public void FindLast_OnSingleElementList_WhenValueMatches_ReturnsValue()
        {    
            var list = new LinkedList();
            list.AddFirst("node1");
            var result = list.FindLast("node1");
            Assert.Equal("node1", result);
        }
        [Fact]
        public void FindLast_OnMultipleElementList_WhenValueDoesNotMatch_ReturnsNull()
        {   
            var list = new LinkedList();
            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            list.AddFirst("node4");
            var result = list.FindLast("node5");
            Assert.Null(result);
        }
        [Fact]
        public void FindLast_OnMultipleElementList_WhenValueMatches_ReturnsValue()
        {
            var list = new LinkedList();
            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            list.AddFirst("node4");
            var result = list.FindLast("node3");
            Assert.Equal("node3", result);
        }
        public void FindLast_OnMultipleElements_WhenValueOccursMultipleTimes_ReturnsLastMatch()
        {
            var list = new LinkedList();
            list.AddLast("node1");
            list.AddLast("node2");
            list.AddLast("node3");
            list.AddLast("node4");
            list.AddLast("node3");
            list.AddLast("node5");
            var result = list.FindLast("node3");
            Assert.Equal("node3", result);
        }
    }
}
