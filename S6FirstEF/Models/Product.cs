﻿using System;
using System.Collections.Generic;

namespace S6FirstEF.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }
}
