//
//      SharedEnums.cs
//
//      Global enums
//
//      *************************** WARNING ***************************
//
//      THIS FILE IS AUTOMATICALLY GENERATED.  DO NOT EDIT THIS FILE AS
//      CHANGES WILL BE OVERWRITTEN.
//
//      ORIGINAL DATA FOR THIS FILE CAN BE FOUND IN THE ESP32 PROJECT.
//
//      *************************** WARNING ***************************
//

using System;

namespace Meadow.Devices.Esp32.MessagePayloads
{
    // <summary>
    // Status and error codes for the various function calls.
    // </summary>
    public enum StatusCodes
    {
        CompletedOk = 0,
        CrcError = 1,
        Restart = 2,
        Failure = 3,
        InvalidInterface = 4,
        QueueError = 5,
        Timeout = 6,
        InvalidPacket = 7,
        InvalidHeader = 8,
        UnexpectedData = 9,
        MissingEndOfFrameMarker = 10,
        HeaderBodyFieldMismatch = 11,
        WiFiAlreadyStarted = 12,
        InvalidWiFiCredentials = 13,
        WiFiDisconnected = 14,
        CannotStartNetworkInterface = 15,
        CannotConnectToAccessPoint = 16,
        InvalidAntennaData = 17,
        InvalidAntennaValue = 18,
        NoMessagesWaiting = 19,
        CoprocessorNotResponding = 20,
        EspWiFiNotStarted = 21,
        EspOutOfMemory = 22,
        EspWiFiInvalidSsid = 23,
        AccessPointNotFound = 24,
        BeaconTimeout = 25,
        AuthenticationFailed = 26,
        AssociationFailed = 27,
        HandshakeTimeout = 28,
        ConnectionFailed = 29,
        ApTsfReset = 30,
        UnmappedErrorCode = 31
    };

    // <summary>
    // System interfaces available on the ESP32 for the various function calls.
    // </summary>
    public enum Esp32Interfaces
    {
        None = 0,
        WiFi = 1,
        BlueTooth = 2,
        MeshNetwork = 3,
        System = 4,
        Transport = 5
    };

    // <summary>
    // System functions available on the ESP32
    // </summary>
    public enum SystemFunction
    {
        GetConfiguration = 0,
        SetConfigurationItem = 1,
        DeepSleep = 2,
        GetBatteryChargeLevel = 3,
        ErrorEvent = 4
    };

    // <summary>
    // WiFi functions available on the ESP32
    // </summary>
    public enum WiFiFunction
    {
        StartNetwork = 0,
        Stop = 1,
        ConnectToAccessPoint = 2,
        DisconnectFromAccessPoint = 3,
        GetAccessPoints = 4,
        GetAddrInfo = 5,
        Socket = 6,
        Connect = 7,
        FreeAddrInfo = 8,
        Write = 9,
        SetSockOpt = 10,
        Read = 11,
        Close = 12,
        SendTo = 13,
        RecvFrom = 14,
        Poll = 15,
        InterruptPollResponse = 16,
        Send = 17,
        Bind = 18,
        Listen = 19,
        Accept = 20,
        Ioctl = 21,
        GetSockName = 22,
        SetAntenna = 23,
        SetTimeOfDayEvent = 24,
        ConnectEvent = 25,
        DisconnectEvent = 26,
        StartInterfaceEvent = 27,
        StopInterfaceEvent = 28
    };

    // <summary>
    // Bluetooth functions available on the ESP32
    // </summary>
    public enum BluetoothFunction
    {
        Start = 0,
        Stop = 1,
        ReadRequestEvent = 2,
        WriteRequestEvent = 3
    };

    // <summary>
    // Transport functions available on the ESP32
    // </summary>
    public enum TransportFunction
    {
        ResponseReady = 0,
        SendResponse = 1,
        KillNuttxThread = 2,
        ResetEsp32 = 3
    };

    // <summary>
    // Possible transport packet types.
    // </summary>
    public enum MessageTypes
    {
        Ack = 0x00,
        Nak = 0x01,
        Reset = 0x02,
        Event = 0x04,
        Response = 0x10,
        Transport = 0x20,
        Header = 0x40,
        Data = 0x80
    };

    // <summary>
    // Name of items that can be configured (changed by the code on the STM32) on the ESP32.
    // </summary>
    public enum ConfigurationItems
    {
        MaximumMessageQueueLength = 0,
        AutomaticallyStartNetwork = 1,
        AutomaticallyReconnect = 2,
        MaximumRetryCount = 3,
        DeviceName = 4,
        DefaultApAndPassword = 5,
        NtpServer = 6,
        GetTimeAtStartup = 7,
        UseDhcp = 8,
        StaticIpAddress = 9,
        DnsServer = 10,
        DefaultGateway = 11,
        Antenna = 12,
        BoardMacAddress = 13,
        SoftApMacAddress = 14
    };

    // <summary>
    // WiFi reason codes
    // </summary>
    public enum WiFiReasons
    {
        Unspecified = 1,
        AuthenticationExpired = 2,
        AuthenticationLeave = 3,
        AssociationExpired = 4,
        AssociationTooMany = 5,
        NotAuthenticated = 6,
        NotAssociated = 7,
        AssociationLeave = 8,
        AssociationNotAuthorized = 9,
        DisassociatedPowerCapabilityBad = 10,
        DisassociatedSupplementaryChannelBad = 11,
        InvalidElement = 13,
        MessageIntegrityCodeFailure = 14,
        FourWayHandshakeTimeout = 15,
        GroupKeyUpdateTimeout = 16,
        InvalidElementInFourWayHandshake = 17,
        InvalidGroupCipher = 18,
        InvalidPairwiseCipher = 19,
        InvalidAkmp = 20,
        UnsupportedRsneVersion = 21,
        InvalidRsneCapabilities = 22,
        Authentication801Failed = 23,
        CipherSuiteRejected = 24,
        InvalidPmkid = 53,
        BeaconTimeout = 200,
        NoAccessPointFound = 201,
        AuthenticationFailed = 202,
        AssociationFailed = 203,
        HandshakeTimeout = 204,
        ConnectionFailed = 205,
        TsfReset = 206
    };

    // <summary>
    // Access point authentication method.
    // </summary>
    public enum WiFiAuthenticationMode
    {
        Open = 0,
        Wep = 1,
        WpaPsk = 2,
        Wpa2Psk = 3,
        WpaWpa2Psk = 4,
        Wpa2Enterprise = 5,
        Wpa3Psk = 6,
        Wpa2Wpa3Psk = 7
    };

    // <summary>
    // WiFi Country Policy.
    // </summary>
    public enum WiFiCountryPolicy
    {
        Automatic = 0,
        Manual = 1
    };

    // <summary>
    // Location of the secondary channel in respect to the primary channel.
    // </summary>
    public enum WiFiSecondChannel
    {
        None = 0,
        Above = 1,
        Below = 2
    };

    // <summary>
    // WiFiScanType
    // </summary>
    public enum WiFiScanType
    {
        Active = 0,
        Passive = 1
    };

    // <summary>
    // Types of antennas that can be selected.
    // </summary>
    public enum AntennaTypes
    {
        OnBoard = 0,
        External = 1,
        Max = 1
    };

    // <summary>
    // Encryption method used by the access point.
    // </summary>
    public enum WiFiCipherType
    {
        None = 0,
        Wep40 = 1,
        Wep104 = 2,
        Tkip = 3,
        Ccmp = 4,
        TkipCcmp = 5,
        Unknown = 6
    };

    // <summary>
    // Address family types for the low level sockets..
    // </summary>
    public enum AddressFamilyType
    {
        AfUnspec = 0,
        AfInet = 2,
        AfInet6 = 10
    };

    // <summary>
    // Protocol family types for the low level sockets..
    // </summary>
    public enum ProtocolFamilyType
    {
        PfUnspec = 0,
        PfInet = 2,
        PfInet6 = 10
    };

    // <summary>
    // Protocol types for the low level sockets.
    // </summary>
    public enum IpProtocolType
    {
        IpProtoIP = 0,
        IpProtoIcmp = 1,
        IpProtoTcp = 6,
        IpProtoUdp = 17,
        IpProtoIpV6 = 41,
        IpProtoIcmpV6 = 58,
        IpProtoUdpLite = 136,
        IpProtoNew = 255
    };

    // <summary>
    // Socket protocol types for the low level sockets.
    // </summary>
    public enum SocketProtocolType
    {
        SockStream = 1,
        SockDgram = 2,
        SockRaw = 3
    };

    // <summary>
    // Socket level types for the low level sockets.
    // </summary>
    public enum SocketLevelType
    {
        SolSocket = 0xfff
    };

    // <summary>
    // Socket option types for the low level sockets.
    // </summary>
    public enum SocketOptionType
    {
        SoDebug = 0x0001,
        SoAcceptConn = 0x0002,
        SoDontRoute = 0x0010,
        UseLoopback = 0x0040,
        SoLinger = 0x0080,
        SoDontLinger = 0xff7f,
        SoOobInline = 0x0100,
        SoReusePort = 0x0200,
        SoSndBuf = 0x1001,
        SoRcvBuf = 0x1002,
        SoSndLoWat = 0x1003,
        SoSRcvLoWat = 0x1004,
        SoSndTimeO = 0x1005,
        SoRcvTimeO = 0x1006,
        SoError = 0x1007,
        SoType = 0x1008,
        SoConTimeO = 0x1009,
        SoNoCheck = 0x100a
    };

    // <summary>
    // ESP32 Error codes (errno).
    // </summary>
    public enum Esp32ErrorCodes
    {
        Perm = 1,
        NoEnt = 2,
        Srch = 3,
        Intr = 4,
        IO = 5,
        NxIO = 6,
        TooBig = 7,
        NoExec = 8,
        BadF = 9,
        Child = 10,
        Again = 11,
        NoMem = 12,
        Acces = 13,
        Fault = 14,
        Busy = 16,
        Exist = 17,
        XDev = 18,
        NoDev = 19,
        NotDir = 20,
        IsDir = 21,
        InVal = 22,
        NFile = 23,
        MFile = 24,
        NoTty = 25,
        TxtBsy = 26,
        FBig = 27,
        NoSpc = 28,
        SPipe = 29,
        RoFs = 30,
        MLink = 31,
        Pipe = 32,
        Dom = 33,
        Range = 34,
        NoMsg = 35,
        IdRm = 36,
        DeadLck = 45,
        NoLock = 46,
        NoStr = 60,
        NoData = 61,
        Time = 62,
        NoSr = 63,
        NoLink = 67,
        Proto = 71,
        MultiHop = 74,
        BadMsg = 77,
        FType = 79,
        NoSys = 88,
        NotEmpty = 90,
        NameTooLong = 91,
        Loop = 92,
        OpNotSupport = 95,
        PNoSupport = 96,
        ConnReset = 104,
        NoBufs = 105,
        AfNoSupport = 106,
        ProtoType = 107,
        NotSock = 108,
        NoProtoOpt = 109,
        ConnRefused = 111,
        AddrInUse = 112,
        ConnAborted = 113,
        NetUnreach = 114,
        NetDown = 115,
        TimedOut = 116,
        HostDown = 117,
        HostUnreach = 118,
        InProgress = 119,
        Already = 120,
        DestAddrReq = 121,
        MsgSize = 122,
        ProtoNoSupport = 123,
        AddrNotAvail = 125,
        NetReset = 126,
        NotConn = 128,
        TooManyRefs = 129,
        DQuot = 132,
        Stale = 133,
        NotSup = 134,
        IlSeq = 138,
        Overflow = 139,
        Cancelled = 140,
        NotRecoverable = 141,
        OwnerDead = 142,
        WouldBlock = 11
    };

}
