namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class PositionTest
{
    [TestMethod]
    public void VerifiesIfPositionObjectIsCreated()
    {
        var position = new Position()
        {
            PositionId = Guid.NewGuid(),
            Code = "Code-1001",
            Description = "Test description",
        };

        Assert.IsNotNull(position);
    }
}
