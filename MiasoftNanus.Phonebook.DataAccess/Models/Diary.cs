namespace MiasoftNanus.Phonebook.DataAccess.Models;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Diary")]
public class Diary
{
    public Guid DiaryId { get; set; }
    public string? Code { get; set; }
    public string? Email { get; set; }
    public bool Enable { get; set; }
    public string? ImagePath { get; set; }
    public string? DirectLine { get; set; }
    public string? Internal { get; set; }
    public string? Corporate { get; set; }
}

