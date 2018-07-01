using Shared.Events.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public delegate void  ChatEventHandler(object sender, ChatEventArgs session);
    public delegate void  ChatEventHandler<ChatArgs>(object sender, ChatArgs chatArgs) where ChatArgs : ChatEventArgs, new();
    public abstract class ChatEventArgs : EventArgs
    {
        // Nothing To See Here..
    }
}
