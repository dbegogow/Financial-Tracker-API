﻿using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Infrastructure.Database.ValidationConstants.Category;

namespace FinancialTracker.Infrastructure.Database.Models;

public class Category
{
    public int Id { get; set; }

    public Guid Identifier { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; }


}
