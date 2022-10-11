namespace MiasoftNanus.Phonebook.DataAccess.Test.Models;

using MiasoftNanus.Phonebook.DataAccess.Models;

[TestClass]
public class DiaryTest
{
    [TestMethod]
    public void VerifiesIfDiaryObjectIsCreated()
    {
        var diary = new Diary()
        {
            DiaryId = Guid.NewGuid(),
            Code = "Code-1",
            Email = "example@miasoftnanus.com",
            Enable = true,
            ImagePath = "../img/image1.jpg",
            DirectLine = "33493949",
            Internal = "345",
            Corporate = "77345634",
        };

        Assert.IsNotNull(diary);
    }
}
