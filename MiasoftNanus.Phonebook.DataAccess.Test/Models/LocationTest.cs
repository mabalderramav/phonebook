namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class LocationTest
{
    [TestMethod]
    public void VerifiesIfLocationObjectIsCreated()
    {
        var location = new Location()
        {
            LocationId = Guid.NewGuid(),
            Description = "test description",
        };

        Assert.IsNotNull(location);
    }
}
