using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using RconSharp;
using RconSharp.Net45;

namespace StarboundRcon
{
    public class RconManager
    {
        /// <summary>
        /// Gets or sets the RCON server IP address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the RCON server port.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Sets the RCON server password.
        /// </summary>
        public string Password { private get; set; }

        /// <summary>
        /// Gets a value indicating whether the current <see cref="Password"/> is valid (not null, not empty).
        /// </summary>
        public bool ValidPassword
        {
            get
            {
                return !string.IsNullOrEmpty(Password);
            }
        }

        /// <summary>
        /// Instantiates an RCON manager with the given credentials.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        public RconManager(string address, int port, string password)
        {
            Address = address;
            Port = port;
            Password = password;
        }

        /// <summary>
        /// Asynchronously sends an RCON command to the server.
        /// Returns the response the server sent back.
        /// </summary>
        /// <param name="command">Command to send.</param>
        /// <returns>Server response.</returns>
        public async Task<string> RunCommand(string command)
        {
            INetworkSocket socket = new RconSocket();
            RconMessenger messenger = new RconMessenger(socket);

            try
            {
                bool isConnected = await messenger.ConnectAsync(Address, Port);
                bool authenticated = await messenger.AuthenticateAsync(Password);

                if (authenticated)
                {
                    return await messenger.ExecuteCommandAsync(command);
                }
                else
                {
                    return "Authentication failed.";
                }
            }
            catch (SocketException exc)
            {
                return "Connection failed:\n" + exc.Message;
            }
            catch (AggregateException exc)
            {
                if (exc.InnerException.GetType() == typeof(SocketException))
                {
                    return "Connection failed:\n" + exc.InnerException;
                }
                else
                {
                    return "Exception unaccounted for:\n" + exc.Message;
                }
            }
            catch (Exception exc)
            {
                return "Exception unaccounted for:\n" + exc.Message;
            }
            finally
            {
                messenger.CloseConnection();
                socket.CloseConnection();
            }
        }
    }
}
