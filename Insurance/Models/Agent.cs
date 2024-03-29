﻿using System;
using System.Collections.Generic;

namespace Insurance.Models;

public partial class Agent
{
    public int AgentId { get; set; }

    public int? LoginId { get; set; }

    public string AgentName { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public decimal? PhoneNum { get; set; }

    public string Dob { get; set; } = null!;

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int Grade { get; set; }

    public string? ProfilePic { get; set; }

    public int Status { get; set; }

    public virtual ICollection<ClientPolicy> ClientPolicies { get; } = new List<ClientPolicy>();
}
