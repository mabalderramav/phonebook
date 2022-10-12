namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Location")]
public class Location
{
    public Location()
    {
        LocationId = Guid.Empty;
        Description = String.Empty;
    }

    public Guid LocationId { get; set; }
    public string Description { get; set; }
}