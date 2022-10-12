namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class AreaTest
{
    [TestMethod]
    public void VerifiesIfAreaObjectIsCreated()
    {
        var area = new Area()
        {
            AreaId = Guid.NewGuid(),
            Code = "Code-2001",
            Description = "Test description",
        };

        Assert.IsNotNull(area);
    }
}
