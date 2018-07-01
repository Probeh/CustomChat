using MetroFramework;
using MetroFramework.Forms;
using Shared.Events;
using Shared.Models;
using Shared.Services;
using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : MetroForm
    {
        // Properties
        #region Properties
        public Network Network { get; set; }
        public Profile Profile { get; set; }
        #endregion
        
        // Constructor
        public Client()
        {
            this.Network = new Network();
            this.Profile = new Profile();

            #region Initializing Form
            InitializeComponent();

            this.metroControl.SelectedIndex = 0;
            this.Size = new Size(((int)(Screen.PrimaryScreen.Bounds.Width / 2.5)), Screen.PrimaryScreen.Bounds.Height / 2);
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - this.Width / 5, this.Height / 4);
            this.Resizable = true;
            this.btnSend.Enabled = false;
            this.lstMessageBox.Columns[2].Resizable = DataGridViewTriState.False;
            this.lstMessageBox.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.lstMessageBox.Columns[2].Width = 150;
            #endregion

            #region Settings Events Chaining
            // Network Event Chaining
            this.Network.OnLocalConnect += this.OnConnect;
            this.Network.OnLocalDisconnect += this.OnDisconnect;
            // Radios
            this.rdoDefault.CheckedChanged += new EventHandler(this.RdoDefault_CheckedChanged);
            this.rdoDefault.CheckedChanged += new EventHandler(this.CriteriaCheck);
            this.rdoManual.CheckedChanged += new EventHandler(this.RdoManual_CheckedChanged);
            this.rdoManual.CheckedChanged += new EventHandler(this.CriteriaCheck);
            // Text Fields
            this.txtUsername.TextChanged += new EventHandler(this.CriteriaCheck);
            this.txtIPAddress.TextChanged += new EventHandler(this.CriteriaCheck);
            this.txtPortNumber.TextChanged += new EventHandler(this.CriteriaCheck);
            this.txtUsername.TextChanged += new EventHandler(this.CriteriaCheck);
            this.txtMessage.KeyUp += new KeyEventHandler(this.txtMessage_KeyUp);
            // Buttons
            this.btnCheckIP.Click += new EventHandler(this.BtnCheckIP_Click);
            this.btnCheckPort.Click += new EventHandler(this.BtnCheckPort_Click);
            this.btnConnect.Click += new EventHandler(this.BtnConnect_Click);
            #endregion

            #region ChatRoom Events Chaining
            // Components
            this.txtMessage.TextChanged += new EventHandler(this.txtMessage_TextChanged);
            this.Network.OnIncomingMessage += this.IncomingMessage;
            this.Network.OnIncomingUser += this.IncomingUser;
            #endregion
        }

        #region Component Handlers
        // Button Handlers
        private void BtnCheckIP_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(this.txtIPAddress.Text, out IPAddress tempValue))
            {
                MetroMessageBox.Show(this, $"\nIP Address: {this.txtIPAddress.Text} Is Valid",
                    $"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this, $"\nThe IP: {this.txtIPAddress.Text} Is Invalid..\nPlease Try Again\n\nExample: '127.0.0.138'",
                    $"Criteria Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (dr == DialogResult.Retry)
                {
                    this.txtIPAddress.Text = string.Empty;
                    this.btnCheckIP.Visible = false;
                }
                else { this.Close(); }

                this.txtIPAddress.Text = string.Empty;
                this.btnCheckIP.Visible = false;
            }
        }
        private void BtnCheckPort_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtPortNumber.Text, out int tempValue))
            {
                MetroMessageBox.Show(this, $"\nUsername: {this.txtPortNumber.Text} Is Valid", $"Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this, $"\nThe Port: {this.txtPortNumber.Text} Is Invalid..\nPlease Try Again\n\nExample: '4500'",
                    $"Criteria Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (dr == DialogResult.Retry)
                {
                    this.txtPortNumber.Text = string.Empty;
                    this.btnCheckPort.Visible = false;
                }
                else { this.Close(); }

                this.txtPortNumber.Text = string.Empty;
                this.btnCheckPort.Visible = false;
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, $"\nEstablishing Network Connection..",
                    $"Connecting", MessageBoxButtons.OK, MessageBoxIcon.Question);

            try
            {
                this.Network.StartSession(new SessionEventArgs()
                {
                    Profile = new Profile()
                    {
                        Settings = new Settings() { Text = this.txtUsername.Text }
                    },
                    Connection = new Connection()
                    {
                        EndPoint = new IPEndPoint(IPAddress.Parse(this.txtIPAddress.Text), int.Parse(this.txtPortNumber.Text))
                    }
                });
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"\nNetwork Connection Failed..\n" +
                    $"IP: {this.txtIPAddress.Text} " +
                    $"Port: {this.txtPortNumber.Text}\n" +
                    $"\n{ex.Message}",
                    $"Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var message = new Shared.Models.Message()
            {
                ComposerID = this.Profile.ProfileID,
                Settings = new Settings()
                {
                    Text = this.txtMessage.Text
                }
            };
            if (colorDialog.ShowDialog() == DialogResult.OK) { message.Settings.Color = colorDialog.Color; }

            this.Network.RequestHandler(message);
            this.txtMessage.Clear();
        }
        // Radio Handlers
        private void RdoManual_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUsername.Text = string.Empty;
            this.txtIPAddress.Text = string.Empty;
            this.txtPortNumber.Text = string.Empty;
            this.CriteriaCheck(sender, null);
        }
        private void RdoDefault_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUsername.Text = $"User-{Environment.UserName}-{new Random().Next(1000, 9999)}";
            this.txtIPAddress.Text = "127.0.0.138";
            this.txtPortNumber.Text = "4500";
            this.CriteriaCheck(sender, null);
        }
        // Text Box Handlers
        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(this.txtMessage.Text))
            {
                this.btnSend_Click(this, null);
                this.txtMessage.Clear();
            }
        }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtMessage.Text))
            {
                this.btnSend.Enabled = true;
            }
            else { this.btnSend.Enabled = false; }
        }
        #endregion

        #region Network Handlers
        private void OnConnect(object sender, SessionEventArgs e)
        {
            MetroMessageBox.Show(this, $"\nNetwork Connection Successfully Established..\n\n" +
                    $"IP: {e.Connection.EndPoint.Address}\n" +
                    $"Port: {e.Connection.EndPoint.Port}",
                    $"Connected Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.metroControl.SelectedIndex = 1;

        }
        private void OnDisconnect(object sender, SessionEventArgs e)
        {
            MetroMessageBox.Show(this, $"\nNetwork Session Successfully Disposed",
                    $"Disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void IncomingUser(object sender, Profile e)
        {
            this.lstClientList.Items.Add(e.Settings.Text);
            this.lstMessageBox.Rows.Add(e.Settings.Text, "Has Joined The Chat..", $"{DateTime.Now}");
        }
        private void IncomingMessage(object sender, Shared.Models.Message data)
        {
            this.lstMessageBox.Rows.Add("Username..", data.Settings.Text, data.Created);
            this.lstMessageBox.Rows[this.lstMessageBox.RowCount - 1].Cells["Message"].Style.ForeColor = data.Settings.Color;
        }
        #endregion

        // Custom Handlers
        private void CriteriaCheck(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtIPAddress.Text))
            {
                this.btnCheckIP.Visible = true;
            }
            else { this.btnCheckIP.Visible = false; }

            if (!string.IsNullOrWhiteSpace(this.txtPortNumber.Text))
            {
                this.btnCheckPort.Visible = true;
            }
            else { this.btnCheckPort.Visible = false; }

            if (!string.IsNullOrWhiteSpace(this.txtIPAddress.Text) && !string.IsNullOrWhiteSpace(this.txtPortNumber.Text))
            {
                this.btnConnect.Enabled = true;
            }
            else { this.btnConnect.Enabled = false; }
        }
    }
}
