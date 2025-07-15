using Microsoft.VisualStudio.TestTools.UnitTesting;
// TODO Problem 2 - Write and run test cases and fix the code to match requirements.
[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items with different priorities. Dequeue should return highest priority first.
    // Expected Result: "Urgent"
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("Urgent", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Urgent", result);
    }

    [TestMethod]
    // Scenario: Add 2 items with the same priority. First one added should come out first.
    // Expected Result: "First"
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Add multiple and remove them all. They should be removed in proper order.
    // Expected Result: "Urgent", then "Medium", then "Low"
    public void TestPriorityQueue_DequeueAllCorrectOrder()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("Urgent", 10);

        Assert.AreEqual("Urgent", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: Exception thrown
    public void TestPriorityQueue_DequeueEmpty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
