﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Contracts_Interfaces
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
