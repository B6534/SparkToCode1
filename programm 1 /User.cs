using System.Collections.Generic;
namespace programm_1;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public List<Order> Orders { get; set; } = new();
}///
