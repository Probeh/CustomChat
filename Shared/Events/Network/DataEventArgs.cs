using Shared.Enums;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events.Network
{
    public delegate void DataEventHandler(object sender, DataEventArgs data);
    public delegate void DataEventHandler<DataArgs>(object sender, DataArgs dataArgs) where DataArgs : Model, new();
    public class DataEventArgs : ChatEventArgs
    {
        public DataType Type { get; set; }
    }

}
