using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ManagerTests
{
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
}
