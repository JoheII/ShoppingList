using System;
using System.Collections.Generic;

namespace ShoppingList.Models
{
    public partial class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Category { get; set; }
        public int? Persons { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public sbyte? Deactivated { get; set; }
    }
}
