using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WorkerTests
{
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

    private string CaptureConsoleOutput(Action action)
    {
        // Capture console output for testing
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
}
