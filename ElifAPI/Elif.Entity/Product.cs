using System;

namespace Elif.Entity;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; } = true;
}
