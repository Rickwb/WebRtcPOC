using SIPSorcery.Net;
using System.Collections.Generic;

namespace WRTCServer
{
    public class User
    {
        public User(string Name)
        {
            _peerconnections = new List<RTCPeerConnection>();
        }
        public string Name { get; set; }
        public List<RTCPeerConnection> _peerconnections { get; set; }

        
    }
}
