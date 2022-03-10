using Microsoft.Extensions.Logging;
using SIPSorcery.Net;
using System;
using System.Collections.Generic;

namespace WRTCServer
{
    public class Group
    {
        public Group(uint id, string name,ILogger<PeerConnectionManager> _logger)
        {
            GroupId = id;
            Name = name;
            Users = new List<User>();
            _peerConnectionManager= new PeerConnectionManager(_logger);
        }
        public IPeerConnectionManager _peerConnectionManager { get; private set; }

        public uint GroupId { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

    }
}
