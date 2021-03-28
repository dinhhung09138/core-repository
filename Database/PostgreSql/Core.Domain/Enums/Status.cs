using System;
using System.ComponentModel;

namespace Core.Domain
{
    public enum Status
    {
        [Description("Inactive")]
        Inactive = 0,

        [Description("Active")]
        Active = 1,
        
    }
}
