using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server.Logic
{
    public class ClientData
    {
        #region Properties
        // Public Client Properties
        public TcpClient TcpClient { get; private set; }
        public SessionEventArgs Session { get; set; } = new SessionEventArgs();
        // Internal Client Properties
        internal NetworkStream Stream { get; private set; }
        internal BinaryFormatter Binary { get; private set; }
        #endregion

        // Constructor
        public ClientData(TcpClient client)
        {
            this.TcpClient = client;
            this.Stream = new NetworkStream(this.TcpClient.Client);
            this.Binary = new BinaryFormatter();
        }

        internal async Task<bool> Dispose(bool disposable)
        {
            if (disposable)
            {
                try
                {
                    // Disposing Of TcpClient Resources
                    this.TcpClient.Close();
                    this.TcpClient.Dispose();
                    this.TcpClient = null;
                    // Disposing Of Any Stream Resources
                    this.Stream.Close();
                    this.Stream.Dispose();
                    await this.Stream.FlushAsync();
                    this.Stream = null; // <== Just Making Sure The Stream Is Dead

                    return true;
                }
                catch (Exception ex) { throw ex; }
            }
            return false;
        }
    }
}
