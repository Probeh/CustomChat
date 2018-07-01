using Shared.Enums;
using Shared.Events;
using Shared.Models;
using Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Logic
{
    public class ClientHandler
    {
        // Properties
        public ClientData Data { get; set; }

        // Client Events
        #region Client Events
        // Local Network Events
        public event SessionEventHandler OnConnect;
        public event SessionEventHandler<ClientHandler> OnDisconnect;
        // Remote Network Traffic Events
        public event SessionEventHandler<object> OnIncomingRequest;
        public event SessionEventHandler<Message> OnIncomingMessage;
        #endregion

        // Constructor
        public ClientHandler(TcpClient client)
        {
            this.Data = new ClientData(client);

            this.OnIncomingRequest += this.RequestHandler;
        }

        // Initializing Current Session Asynchronously
        public void StartSession()
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        while (this.Data.TcpClient.Connected)
                        {
                            if (this.Data.Stream.DataAvailable && this.Data.Stream.CanRead)
                            {
                                this.OnIncomingRequest?.Invoke(this, this.Data.Binary.Deserialize(this.Data.Stream));
                                this.Data.Stream.FlushAsync();
                            }
                        }
                    }
                    catch (Exception ex) { throw ex; }
                });
            }
            catch (Exception ex) { throw ex; }
        }
        // Traffic Handlers
        private void RequestHandler(object sender, object request)
        {
            if (request is Message)
            {
                // The Server Will Now Proccess The Invoked Event, And Publish Accordingly.
                // After Being Proccessed By The Server, The Message Will Later Be ..
                // .. Returned To The Composer, And Only Then Will It Be Displayed Remotely.
                // The Proccess Will Be Done Via Each Client's 'ResponseHandler' On A Separate Thread.
                this.OnIncomingMessage?.Invoke(this, request as Message);
            }
            else if (request is SessionEventArgs)
            {
                this.Data.Session = request as SessionEventArgs;
                this.OnConnect?.Invoke(this, this.Data.Session);
            }
        }
        private void ConnectHandler(object sender, ClientHandler e)
        {
            // Returning The Current Updated Session Data To The Client For Confirming Connectino Success
            this.ResponseHandler(this.Data.Session);
        }
        public void ResponseHandler(object response)
        {
            try
            {
                this.Data.Binary.Serialize(this.Data.Stream, response);
                this.Data.Stream.FlushAsync();
            }
            catch (Exception ex) { throw ex; }
        }
        // Disconnection Management
        public async Task<bool> DisconnectAsync()
        {
            try
            {
                // Returns An Indicating Value After Completion Of The Awaited Task Below
                return await Task.Run(async () =>
                {
                    try
                    {
                        if (await this.Data.Dispose(true)) { return true; } // <= Awaiting Completion.
                                                                            // If Reached This Line, A Task<true> Value Is Returned & The Method Ends Here.
                                                                            // **Disconnection Was A Success**
                    }
                    catch (Exception ex) { throw ex; } // <= An Exception Was Thrown And ..
                                                       // .. An Error Is Returned Followed By A Default Task<false> Value.

                    // The Dispose Method Was A Failure And The Code Block Ends Here.
                    // **Disconnection Failed**
                    return false; // <= If For Any Reason The Code Reaches This Line ..
                                  // .. Both The Disconnection Failed & An Exception Has Been Thrown.
                                  // Task<false> Is The Return Value Here & The Network Connection Remaines Active.
                                  // **Disconnection Failed**
                });
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                // Finally, Invoking The Server To Update ..
                // .. All Connected Clients Due To The Current Disconnection
                // Regardless Of The Disposal Proccess Attemption Above..
                this.OnDisconnect?.Invoke(this, this);
            }
        }
    }
}
