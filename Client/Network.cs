using Shared;
using Shared.Enums;
using Shared.Events;
using Shared.Models;
using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Client
{
    public class Network
    {
        // Local Fields
        #region Private Fields
        private TcpClient TcpClient = new TcpClient();
        private BinaryFormatter Binary;
        private NetworkStream Stream;
        private SessionEventArgs Session;
        #endregion

        // Client Events
        #region Events
        // Local Session Event Handlers
        public event SessionEventHandler OnLocalConnect;
        public event SessionEventHandler OnLocalDisconnect;
        // Local Request Event Handlers
        public event PacketEventHandler<Message> OnIncomingMessage;
        public event EventHandler<Profile> OnIncomingUser;
        #endregion

        // Constructor
        public Network()
        {
            this.Binary = new BinaryFormatter();
        }

        public async void StartSession(SessionEventArgs session)
        {
            this.TcpClient = new TcpClient();

            try
            {
                await this.TcpClient.ConnectAsync(session.Connection.EndPoint.Address, session.Connection.EndPoint.Port);
                this.Stream = new NetworkStream(this.TcpClient.Client);
                this.RequestHandler(session);
                // Validate Username Before Proceeding
                this.OnLocalConnect?.Invoke(this, session);
                this.NetworkListener();
            }
            catch (Exception ex) { throw ex; }
        }
        private void NetworkListener()
        {
            Task.Run(() =>
            {
                while (this.TcpClient.Connected)
                {
                    if (this.Stream.DataAvailable)
                    {
                        this.ResponseHandler(Binary.Deserialize(this.Stream));
                        this.Stream.FlushAsync();
                    }
                }
            });
        }
        public void RequestHandler(object item)
        {
            this.Binary.Serialize(this.Stream, item);
            this.Stream.FlushAsync();
        }
        private void ResponseHandler(object item)
        {
            if (item is Message) { this.OnIncomingMessage?.Invoke(this, item as Message); }
            else if (item is Profile) { this.OnIncomingUser?.Invoke(this, item as Profile); }
        }
    }
}