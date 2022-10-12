namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class AccessTest
{
    [TestMethod]
    public void VerifiesIfAccessObjectIsCreated()
    {
        var access = new Access()
        {
            AccessId = Guid.NewGuid(),
            Code = "1000000001",
            Name = "Transaction",
            Description = "test descripton",
            Icon = "./icon/test.jpg",
            Place = 3,
            Url = "/transction/",
            Enable = true,
            Clickeable = true,
            AccessRoot = "1000000001",
        };

        Assert.IsNotNull(access);
    }
}
