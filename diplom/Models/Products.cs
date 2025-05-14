﻿using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}