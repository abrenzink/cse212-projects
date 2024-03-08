public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and dequeue until the queue is empty. 
            // create the queue with the values: Value: Harry, Priority: 2, Value: Lucy, Albus: 5, Value: Lilian, Priority: 3
        // Expected Result: Albus, Lilian, Harry
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Harry", 2);
        priorityQueue.Enqueue("Albus", 5);
        priorityQueue.Enqueue("Lilian", 3);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: The node with highest priority is returned all times

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue items with the same priority and dequeue until the queue is empty
            // create the queue with the values: Value: Harry, Priority: 2, Value: Albus, Priority: 5, Value: Draco, Priority: 2
        // Expected Result: Albus, Harry, Draco
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Harry", 2);
        priorityQueue.Enqueue("Albus", 5);
        priorityQueue.Enqueue("Draco", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Elements with same priority where not dequeued as FIFO.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to dequeue from an empty queue
        // Expected Result: Display an error message when attempting to dequeue from an empty queue
        Console.WriteLine("Test 3");
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: No defects found.

        Console.WriteLine("---------");
    }
}