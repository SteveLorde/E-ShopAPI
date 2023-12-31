﻿using System.ComponentModel.DataAnnotations;

namespace API.Data.Models;

public class PurchaseLog
{
    [Key]
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public bool accepted { get; set; }
    public DateTime datetime { get; set; }
}