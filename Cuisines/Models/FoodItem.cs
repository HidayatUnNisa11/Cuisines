using System;
using System.Collections.Generic;

namespace Cuisines.Models;

public partial class FoodItem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }
}
