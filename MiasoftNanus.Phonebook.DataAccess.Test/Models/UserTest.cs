namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class UserTest
{
    [TestMethod]
    public void VerifiesIfUserObjectIsCreated()
    {
        var user = new User()
        {
            UserId = Guid.NewGuid(),
            Name = "ombalderramav",
            Password = "****",
            Enable = true,
            RoleId = Guid.NewGuid(),
        };

        Assert.IsNotNull(user);
    }
}
