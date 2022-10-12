namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Area")]
public class Area
{
    public Area()
    {
        AreaId = Guid.Empty;
        Code = String.Empty;
        Description = String.Empty;
    }

    public Guid AreaId { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
}