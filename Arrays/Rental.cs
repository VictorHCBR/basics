namespace Arrays;

public class Rental
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Room { get; set; }

    public Rental(string name, string email, int room)
    {
        Name = name;
        Email = email;
        Room = room;
    }
}
