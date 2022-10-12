namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Role")]
public class Role
{
    public Role()
    {
        RoleId = Guid.Empty;
        Description = String.Empty;
    }

    public Guid RoleId { get; set; }
    public string Description { get; set; }
}