using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum_It_Security_Project.Model.DAL
{
    public class MemberDAL
    {
        public void ChangePassword(int userID, string password)
        {
            throw new NotImplementedException();
        }

        public void RegisterMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void RemoveMember(int userID)
        {
            throw new NotImplementedException();
        }

        public void BanMember(string ipAddress, long timeTicks)
        {
            throw new NotImplementedException();
        }

        public bool IsMemberBanned(string ipAddress, string time)
        {
            throw new NotImplementedException();
        }
    }
}