using System;
using System.Collections.Generic;
namespace programm_1;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public int UserId { get; set; }
    public User User { get; set; }

    public List<OrderProduct> OrderProducts { get; set; } = new();
    public Review Review { get; set; }
}