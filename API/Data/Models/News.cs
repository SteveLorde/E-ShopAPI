﻿using System.ComponentModel.DataAnnotations;

namespace API.Data.Models;

public class News
{
    [Key]
    public Guid Id { get; set; }
    public string title { get; set; }
    public string? subtitle { get; set; }
    public string? description { get; set; }
    public DateOnly? published { get; set; }
    public string? image { get; set; }
    
}