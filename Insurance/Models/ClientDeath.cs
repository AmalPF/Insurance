﻿using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class ClientDeath
{
    public int ClientDeathId { get; set; }

    public int? ClientPolicyId { get; set; }

    public string? Dod { get; set; }

    public string? StartDate { get; set; }

    public decimal? ClaimAmount { get; set; }

    public virtual ClientPolicy? ClientPolicy { get; set; }
}
