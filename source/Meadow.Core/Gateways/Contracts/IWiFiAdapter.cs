using System.Net;
using Meadow.Gateway.WiFi;
using System.Collections.ObjectModel;

namespace Meadow.Gateway
{
    public interface IWiFiAdapter
    {
        /// <summary>
        /// Indicate if the network adapter is connected to an access point.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// IP Address of the network adapter.
        /// </summary>
        IPAddress IpAddress { get; }

        /// <summary>
        /// Subnet mask of the adapter.
        /// </summary>
        IPAddress SubnetMask { get; }

        /// <summary>
        /// Default gateway for the adapter.
        /// </summary>
        IPAddress Gateway { get; }

        /// <summary>
        /// Get the network time when the WiFi adapter starts?
        /// </summary>
        bool GetNetworkTimeAtStartup { get; }

        /// <summary>
        /// Address of the NTP server.
        /// </summary>
        string NtpServer { get; }

        /// <summary>
        /// Name of the board on the network.
        /// </summary>
        string DeviceName { get; }

        /// <summary>
        /// MAC address of the board when acting as a client.
        /// </summary>
        byte[] MacAddress { get; }

        /// <summary>
        /// MAC address of the board when acting as a sft access point.
        /// </summary>
        byte[] ApMacAddress { get; }

        /// <summary>
        /// Automatically start the network interface when the board reboots?
        /// </summary>
        /// <remarks>
        /// This will automatically connect to any preconfigured access points if they are available.
        /// </remarks>
        bool AutomaticallyStartNetwork { get; }

        /// <summary>
        /// Automatically try to reconnect to an access point if there is a problem / disconnection?
        /// </summary>
        bool AutomaticallyReconnect { get; }

        /// <summary>
        /// Default access point to try to connect to if the network interface is started and the board
        /// is configured to automatically reconnect.
        /// </summary>
        string DefaultAcessPoint { get; }

        /// <summary>
        /// Start the network interface on the WiFi adapter.
        /// </summary>
        /// <remarks>
        /// This method starts the network interface hardware.  The result of this action depends upon the
        /// settings stored in the WiFi adapter memory.
        ///
        /// No Stored Configuration
        /// If no settings are stored in the adapter then the hardware will simply start.  IP addresses
        /// will not be obtained in this mode.
        ///
        /// In this case, the return result indicates if the hardware started successfully.
        ///
        /// Stored Configuration Present
        /// If a default access point (and optional password) are stored in the adapter then the network
        /// interface and the system is set to connect at startup then the system will then attempt to
        /// connect to the specified access point.
        ///
        /// In this case, the return result indicates if the interface was started successfully and a
        /// connection to the access point was made.
        /// </remarks>
        /// <returns>true if the adapter was started successfully, false if there was an error.</returns>
        bool StartNetwork();

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="reconnection">Should the adapter reconnect automatically?</param>
        /// <exception cref="ArgumentNullException">Thrown if the ssid is null or empty or the password is null.</exception>
        /// <returns>true if the connection was successfully made.</returns>
        ConnectionResult Connect(string ssid, string password, ReconnectionType reconnection = ReconnectionType.Automatic);

        /// <summary>
        /// Get the list of access points.
        /// </summary>
        /// <remarks>
        /// The network must be started before this method can be called.
        /// </remarks>
        /// <returns>ObservableCollection (possibly empty) of access points.</returns>
        ObservableCollection<WifiNetwork> Scan();
    }
}