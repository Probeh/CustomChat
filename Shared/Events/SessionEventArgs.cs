using Shared.Models;
using System;

namespace Shared.Events
{
    public delegate void SessionEventHandler(object sender, SessionEventArgs session);
    public delegate void SessionEventHandler<TData>(object sender, TData session);
    public delegate void SessionEventHandler<DataKey, DataValue>(object sender, DataKey sessionKey, DataValue sessionValue);

    [Serializable]
    public class SessionEventArgs : EventArgs
    {
        public Connection Connection{ get; set; }
        public Profile Profile { get; set; }

        public SessionEventArgs()
        {

        }
    }
}
