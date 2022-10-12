namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class User
{
    public User()
    {
        UserId = Guid.Empty;
        Name = string.Empty;
        Password = string.Empty;
        Enable = false;
        RoleId = Guid.Empty;
    }

    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool Enable { get; set; }
    public Guid RoleId { get; set; }
}