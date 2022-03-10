using SIPSorcery.Net;
using System.Collections.Generic;

namespace WRTCServer
{
    public class GroupManager
    {
        private uint _groupID;
        public List<Group> Groups { get; set; }

        public GroupManager()
        {
            _groupID = 1;
        }

        public void CreateGroup(string name)
        {
            Groups.Add(new Group(_groupID,name));
            _groupID++;
        }

        public async void AddPeerToGroup(User user,int groupID)
        {
            var gp = Groups.Find(x => x.GroupId == groupID);

            var offer=await gp._peerConnectionManager.CreateServerOffer();
            user._peerconnections.Add(offer.Item3);
            gp.Users.Add(user);
            Groups[Groups.IndexOf(gp)] = gp;
        }
        
    }
}
