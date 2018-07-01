using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events.Network
{
    public delegate void ClientEventHandler(object sender, ClientEventArgs client);
    public class ClientEventArgs : EventArgs
    {
    }
}
