using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Testing Priority Queue with positive number as priority values
    // Expected Result: Return Anna
    // Defect(s) Found: No defects found
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Marcos", 50);
        priorityQueue.Enqueue("Anna", 70);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Rafael", 37);


        var result = priorityQueue.Dequeue();

        if (String.IsNullOrEmpty(result))
        {
            Assert.Fail("The value must not be empty.");
        }

        Assert.AreEqual("Anna", result);

    }

    [TestMethod]
    // Scenario: Testing Priority Queue with negative number as priority values
    // Expected Result: Return Tim
    // Defect(s) Found: No defects found
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", -2);
        priorityQueue.Enqueue("Marcos", -50);
        priorityQueue.Enqueue("Anna", -70);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Rafael", -37);


        var result = priorityQueue.Dequeue();

        if (String.IsNullOrEmpty(result))
        {
            Assert.Fail("The value must not be empty.");
        }

        Assert.AreEqual("Tim", result);
    }

    [TestMethod]
    // Scenario: Testing Priority Queue with some repetead number as priority values
    // Expected Result: Return Marcos
    // Defect(s) Found: Returned Tim
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", -2);
        priorityQueue.Enqueue("Marcos", 37);
        priorityQueue.Enqueue("Anna", -70);
        priorityQueue.Enqueue("Tim", 37);
        priorityQueue.Enqueue("Rafael", 37);


        var result = priorityQueue.Dequeue();

        if (String.IsNullOrEmpty(result))
        {
            Assert.Fail("The value must not be empty.");
        }

        Assert.AreEqual("Marcos", result);
    }

}