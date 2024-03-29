﻿using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class Premium
{
    public int PremiumId { get; set; }

    public int? ClientPolicyId { get; set; }

    public string? DateOfCollection { get; set; }

    public decimal? Penality { get; set; }

    public virtual ClientPolicy? ClientPolicy { get; set; }
}
