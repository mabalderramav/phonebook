namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

[TestClass]
public class RoleTest
{
    [TestMethod]
    public void VerifiesIfRoleObjectIsCreated()
    {
        var role = new Role()
        {
            RoleId = Guid.NewGuid(),
            Description = "test description",
        };

        Assert.IsNotNull(role);
    }
}
