using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue an item to the back of the queue with the following data and priority: Item1 (1), Item2 (5), Item3 (7), Item4 (3)
    // Expected Result: Item3 (7), Item2 (5), Item4 (3), Item1 (1)
    // Defect(s) Found: The comparsion used in the for loop inside the enqueue method was incorrect, causing that the last item in the queue was never considered properly
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 7);
        priorityQueue.Enqueue("Item4", 3);
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item4", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue an item (some with the same priority as an existing item) and verify the dequeue order respects priority. Items: Item1 (1), Item2 (5), Item3 (5), Item4 (3), Item5 (1)
    // Expected Result: Item2 (5), Item3 (5), Item4 (3), Item1 (1), Item5 (1)
    // Defect(s) Found: The Dequeue method does not respect the order of items with the same priority; it was comparing the priority in a way (_queue[index].Priority >= _queue[highPriorityIndex].Priority) where allways saved the last item with the same priority instead of the first one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 5);
        priorityQueue.Enqueue("Item4", 3);
        priorityQueue.Enqueue("Item5", 1);
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item4", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item5", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Trying to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown
    // Defect(s) Found: no error found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}