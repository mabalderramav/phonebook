namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Position")]
public class Position
{
    public Position()
    {
        PositionId = Guid.Empty;
        Code = String.Empty;
        Description = String.Empty;
    }

    public Guid PositionId { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
}