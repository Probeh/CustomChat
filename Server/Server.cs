using MetroFramework.Forms;
using Server.Logic;
using Shared.Events;
using Shared.Models;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Servers
{
    public partial class Server : MetroForm
    {
        // Constructor
        public Server()
        {
            #region Initialize Form
            InitializeComponent();

            this.Size = new Size(((int)(Screen.PrimaryScreen.Bounds.Width / 2.5)), Screen.PrimaryScreen.Bounds.Height / 2);
            this.Location = new Point(this.Width / 5, this.Height / 4);
            #endregion

            Network Network = new Network();

            #region Event Chaining
            Network.OnLocalConnect += this.OnConnect;
            Network.OnIncomingClient += this.OnRemoteConnect;
            Network.OnIncomingMessage += this.IncomingMessage;
            // Component Events
            this.btnSend.Click += new EventHandler(this.BtnSend_Click);
            #endregion

            try
            {
                // Attempt Initializing Network Connection =>
                Network.StartSession(null, new SessionEventArgs()
                {
                    Profile = new Profile()
                    {
                        Settings = new Settings() { Text = "Admin" }
                    },
                    Connection = new Connection()
                    {
                        EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.138"), 4500)
                    }
                });
            }
            catch (Exception ex) { MessageBox.Show("Error", ex.Message); }
        }

        private void IncomingMessage(object sender, Shared.Models.Message message)
        {
            this.lstMessageBox.Items.Add(message.Settings.Text);
        }
        private void OnRemoteConnect(object sender, SessionEventArgs session)
        {
            if (session.Profile!= null)
            {
                this.lstClientList.Items.Add(session.Profile.Settings.Text);
                this.lstMessageBox.Items.Add($"User {session.Profile.Settings.Text} Has Joined The Chat..");
            }
            else
            {
                MessageBox.Show("nulllllllll");
            }

        }
        private void OnConnect(object sender, SessionEventArgs session)
        {
            this.lstMessageBox.Items.Add("Connected");
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            this.lstMessageBox.Items.Add(this.txtMessage.Text);
        }
    }
}
