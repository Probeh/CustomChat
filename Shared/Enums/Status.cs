using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public enum Status
    {
        // Network Status
        Connected,
        Disconnected = 0,
        // Basic Validation Indicators:
        Success,
        Failure,
        // Detailed Validation Indication:
        InvalidCriteria,
        InvalidIPAddress,
        InvalidPortNumber,
        InvalidPortAndIP,
        // Profile Indicators:
        InvalidUsername // Username Is Taken
    }
}
