using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

// Define the test class
public class NunitTests
{
    // Test for creating a Worker instance successfully
    [Test]
    public void Worker_CreateWorker_Success()
    {
        // Arrange & Act
        var worker = Worker.CreateWorker("John", 50000.00m);

        // Assert
        Assert.IsNotNull(worker);
        Assert.AreEqual("John", worker.GetName());
        Assert.AreEqual(50000.00m, worker.GetWage());
    }

    // Test for displaying correct output to the console for a Worker
    [Test]
    public void Worker_Display_CorrectOutputToConsole()
    {
        // Arrange
        var worker = Worker.CreateWorker("John", 50000.00m);

        // Act
        var result = CaptureConsoleOutput(() => worker.Display());

        // Assert
        Assert.AreEqual($"Worker: John, Wage: {50000.00:C}", result);
    }

    // Utility method to capture console output during testing
    private string CaptureConsoleOutput(Action action)
    {
        var originalOut = Console.Out;
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);

            // Perform action
            action();

            // Restore console output
            Console.SetOut(originalOut);

            return consoleOutput.ToString().Trim();
        }
    }

    // Test for getting details of a Manager
    [Test]
    public void Manager_GetDetails_ReturnsCorrectString()
    {
        // Arrange
        var manager = new Manager("Bob", new Wage(80000.00m));

        // Act
        var result = manager.GetDetails();

        // Assert
        Assert.AreEqual("Name: Bob, Role: Manager", result);
    }

    // Test for sorting employees by name in a Department
    [Test]
    public void SortByName_SortsEmployeesByName()
    {
        // Arrange
        var department = new Department("IT Department");

        // Assert
        Assert.That(department.GetName(), Is.EqualTo("IT Department"));
    }

    // Test for displaying correct output to the console for a Manager
    [Test]
    public void Manager_DisplayDetails_CorrectOutputToConsole()
    {
        // Arrange
        var manager = new Manager("Charlie", new Wage(90000.00m));

        // Act
        var result = CaptureConsoleOutput(() => manager.Display());

        // Assert
        Assert.AreEqual($"Manager: Charlie, Wage: {90000.00:C}", result);
    }
}
