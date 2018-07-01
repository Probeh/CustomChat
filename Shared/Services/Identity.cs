using Shared.Enums;
using Shared.Events;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services
{
    public class Identity
    {
        public DataType ResultType(object data)
        {
            if (data is Connection) { return DataType.Connection; }
            else if (data is Message) { return DataType.Message; }
            else if (data is Profile) { return DataType.Profile; }
            else if (data is Settings) { return DataType.Settings; }
            else if (data is SessionEventArgs) { return DataType.SessionData; }
            else return DataType.Other;
        }
    }
}
