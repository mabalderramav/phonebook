namespace MiasoftNanus.Phonebook.DataAccess;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Access")]
public class Access
{
    public Access()
    {
        AccessId = Guid.Empty;
        Code = String.Empty;
        Name = String.Empty;
        Description = String.Empty;
        Icon = String.Empty;
        Place = 0;
        Url = String.Empty;
        Enable = false;
        Clickeable = false;
        AccessRoot = String.Empty;
    }

    public Guid AccessId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public int Place { get; set; }
    public string Url { get; set; }
    public bool Enable { get; set; }
    public bool Clickeable { get; set; }
    public string AccessRoot { get; set; }
}