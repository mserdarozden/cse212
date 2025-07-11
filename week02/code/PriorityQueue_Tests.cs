using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 3);

        var expectedResult = "Task3"; // Highest priority should be dequeued first

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, dequeuedValue);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 3);
        priorityQueue.Enqueue("Task4", 3);

        var expectedResult = "Task3"; // Highest priority should be dequeued first

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, dequeuedValue);    
    }

    // Add more test cases as needed below.
}