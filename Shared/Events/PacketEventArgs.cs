using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public delegate void PacketEventHandler(object sender, object data);
    public class PacketEventArgs : EventArgs
    {
        public Model Instance { get; set; }

        public PacketEventArgs()
        {

        }
    }

    public delegate void PacketEventHandler<TData>(object sender, TData data);
    public class PacketEventArgs<TData> : PacketEventArgs where TData : Model, new()
    {
        public new TData Instance { get; set; }

    }
}
