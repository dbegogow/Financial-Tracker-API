﻿namespace FinancialTracker.Data.Database.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using static FinancialTracker.Data.Database.ValidationConstants.Transaction;

public class Transaction
{
    public int Id { get; set; }

    public Guid Identifier { get; set; }

    [Required]
    public string UserId { get; set; }

    public User User { get; set; }

    [Precision(14, 2)]
    public decimal Amount { get; set; }

    [StringLength(DescriptionMaxLength)]
    public string Description { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; }

    public int TransactionTypeId { get; set; }

    public TransactionType TransactionType { get; set; }

    public DateTime CreatedAt { get; set; }
}
