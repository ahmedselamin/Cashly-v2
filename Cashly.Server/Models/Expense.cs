﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cashly.Server.Models;
public class Expense
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required, Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }
    [Required]
    public string Category { get; set; } = string.Empty;
    public int UserId { get; set; }
}
