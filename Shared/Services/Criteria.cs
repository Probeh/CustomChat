using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Shared.Services
{
    public class Criteria
    {
        public KeyValuePair<Status, string> UsernameCheck(string username)
        {
            try
            {
                if (!string.IsNullOrEmpty(username))
                {
                    // Check Database For Existing Username
                    return new KeyValuePair<Status, string>(Status.Success, username);
                }
                return new KeyValuePair<Status, string>(Status.InvalidUsername, username);
            }
            catch (Exception ex) { throw ex; }
        }
        public KeyValuePair<Status, IPAddress> IpAddressCheck(string ipAddress)
        {
            try
            {
                if (IPAddress.TryParse(ipAddress, out IPAddress tmpAddress))
                {
                    return new KeyValuePair<Status, IPAddress>(Status.Success, tmpAddress);
                }
                return new KeyValuePair<Status, IPAddress>(Status.InvalidIPAddress, null);
            }
            catch (Exception ex) { throw ex; }
        }
        public KeyValuePair<Status, int> PortNumberCheck(string port)
        {
            try
            {
                if (int.TryParse(port, out int tmpPort))
                {
                    return new KeyValuePair<Status, int>(Status.Success, tmpPort);
                }
                return new KeyValuePair<Status, int>(Status.Failure, 0);
            }
            catch (Exception ex) { throw ex; }
        }
        public KeyValuePair<Status, IPEndPoint> EndPointCheck(string ipAddress, string port)
        {
            try
            {
                if (IpAddressCheck(ipAddress).Key == Status.Success)
                {
                    if (PortNumberCheck(port).Key == Status.Success)
                    {
                        return new KeyValuePair<Status, IPEndPoint>(Status.Success, new IPEndPoint(IpAddressCheck(ipAddress).Value, PortNumberCheck(port).Value));
                    }
                    return new KeyValuePair<Status, IPEndPoint>(Status.InvalidPortNumber, null);
                }
                if (PortNumberCheck(port).Key == Status.Success)
                {
                    return new KeyValuePair<Status, IPEndPoint>(Status.InvalidIPAddress, null);
                }
                return new KeyValuePair<Status, IPEndPoint>(Status.InvalidPortAndIP, null);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}