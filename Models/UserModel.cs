namespace phoenix_project.Models;

public class UserModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime DateDeCreation { get; set; }
}
