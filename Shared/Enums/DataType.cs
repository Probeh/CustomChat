using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public enum DataType
    {
        Connection = 0,
        Message,
        Disconnection,
        NetworkError,
        Settings,
        ServerMessage,
        Profile,
        SessionData,
        Other
    }
}
