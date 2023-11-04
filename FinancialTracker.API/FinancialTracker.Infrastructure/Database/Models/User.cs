﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

using static FinancialTracker.Infrastructure.Database.ValidationConstants.User;

namespace FinancialTracker.Infrastructure.Database.Models;

public class User : IdentityUser
{
    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string LastName { get; set; }
    
    public DateTime CreatedAt { get; set; }
}