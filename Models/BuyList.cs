using System;
using System.Collections.Generic;

namespace ShoppingList.Models
{
    public partial class BuyList
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Amount { get; set; }
        public string? Unit { get; set; }
        public string? Category { get; set; }
        public int? MealListId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public sbyte? Deactivated { get; set; }
    }
}
