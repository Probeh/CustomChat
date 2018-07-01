using Shared.Events;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server.Logic
{
    public class Network
    {
        // Local Events
        #region Private Fields
        private List<ClientHandler> SessionList;
        private TcpListener Listener;
        #endregion

        // Server Events
        #region Events
        // Local Event Handlers
        public event SessionEventHandler OnLocalConnect;
        public event SessionEventHandler OnLocalDisconnect;
        // Remote Event Handlers
        public event SessionEventHandler OnIncomingClient;
        public event SessionEventHandler<ClientHandler> OnRemoteConnect;
        public event SessionEventHandler<ClientHandler> OnRemoteDisconnect;
        public event SessionEventHandler<Message> OnIncomingMessage;
        #endregion

        // Constructor
        public Network()
        {
            this.SessionList = new List<ClientHandler>();

            // Local Network Event Binding
            this.OnLocalConnect += this.NetworkListener;
            this.OnIncomingClient += this.IncomingClient;
            this.OnRemoteConnect += this.RemoteHandler;
            this.OnRemoteDisconnect += this.ClientDisconnection;
        }

        private void IncomingClient(object sender, SessionEventArgs session)
        {
            foreach (ClientHandler item in this.SessionList)
            {
                if (item.Data.Session.Profile.ProfileID == session.Profile.ProfileID)
                {
                    foreach (var client in this.SessionList)
                    {
                        item.ResponseHandler(client.Data.Session.Profile);
                    }
                }
                else { item.ResponseHandler(session.Profile); }
            }

        }

        public void StartSession(object sender, SessionEventArgs session)
        {
            this.Listener = new TcpListener(session.Connection.EndPoint);
            this.Listener.Start();
            // If Current Connection Attempt Succeeded.. =>
            this.OnLocalConnect?.Invoke(this, session);
        }
        private async void NetworkListener(object sender, EventArgs e)
        {
            while (true)
            {
                // Instantiating A New Handler For Incoming Remote Awaited Connection =>
                var remoteSession = new ClientHandler(await this.Listener.AcceptTcpClientAsync());
                // Remote Client Is Now Passed On For Further Proccessing
                this.OnRemoteConnect?.Invoke(this, remoteSession);
                //this.RemoteHandler(this, remoteSession);
            }
        }
        private void RemoteHandler(object sender, ClientHandler session)
        {
            // Binding Network Events For Futher Functionality
            session.OnConnect += this.OnIncomingClient;
            session.OnDisconnect += this.OnRemoteDisconnect;
            session.OnIncomingMessage += this.OnIncomingMessage;
            session.OnIncomingMessage += this.MessageHandler;
            // Adding Session To Global List
            this.SessionList.Add(session);
            // Initializing Session Handler
            session.StartSession();

            //this.OnIncomingClient?.Invoke(this, session.Data.Session);
        }

        private void MessageHandler(object sender, Message session)
        {
            foreach (ClientHandler item in this.SessionList)
            {
                item.ResponseHandler(session);
            }
        }

        private void EndSession()
        {

        }
        private void ClientDisconnection(object sender, ClientHandler session)
        {
            throw new NotImplementedException();
        }
    }
}
