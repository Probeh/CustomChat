using Shared.Enums;
using System;
using System.Net;

namespace Shared.Models
{
    [Serializable]
    public class Connection : Profile
    {
        // Properties
        public IPEndPoint EndPoint { get; set; }
        public Status Status { get; set; } = Status.Disconnected;

        #region Constructors
        // Default Constructor
        public Connection()
        {
            this.Initializer();
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="endPoint">A Single IPEndPoint Containing Both IPAddress & Port Values</param>
        public Connection(IPEndPoint endPoint) : this()
        {
            this.EndPoint = endPoint;
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="ip">IPAddress Value</param>
        /// <param name="port">Port Number</param>
        public Connection(IPAddress ip, int port) : this(new IPEndPoint(ip, port))
        {
            // Nothing To See Here..
        }
        #endregion

        internal override void Initializer()
        {
            base.Initializer();
        }
    }
}
