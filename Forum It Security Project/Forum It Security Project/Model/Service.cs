using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Forum_It_Security_Project.Model.DAL;

namespace Forum_It_Security_Project.Model
{
    public class Service
    {
        private MemberDAL m_memberDAL;
        private ThreadDAL m_threadDAL;
        private LoggingDAL m_loggingDAL;

        MemberDAL MemberDAL 
        {
            get { return this.m_memberDAL ?? (this.m_memberDAL = new MemberDAL()); }
        }

        ThreadDAL ThreadDAL
        {
            get { return this.m_threadDAL ?? (this.m_threadDAL = new ThreadDAL());  }
        }

        LoggingDAL LoggingDAL
        {
            get { return this.m_loggingDAL ?? (this.m_loggingDAL = new LoggingDAL()); }
        }

        public void CreateThread(Thread thread)
        {
            this.m_threadDAL.CreateThread(thread);
        }

        public void PostComment(int threadID, int userID, string comment)
        {
            this.m_threadDAL.PostComment(threadID, userID, comment);
        }

        public List<Thread> GetThreads() 
        {
            return this.m_threadDAL.GetThreads();
        }

        public Thread GetThreadByID(int threadID) 
        {
            return this.m_threadDAL.GetThreadByID(threadID);
        }

        public void DeleteThread(int threadID) 
        {
            this.m_threadDAL.DeleteThread(threadID);
        }

        public List<Comment> GetCommentsByThreadByID(int threadID) 
        {
            try
            {
                return m_threadDAL.GetCommentsByThreadID(threadID);
            }

            catch
            {
 
            }

            return null;
        }

        public void ChangePassword(int userID, string password) 
        {
            this.m_memberDAL.ChangePassword(userID, password);
        }

        public void RegisterMember(Member member) 
        {
            this.m_memberDAL.RegisterMember(member);
        }

        public void RemoveMember(int userID) 
        {
            this.m_memberDAL.RemoveMember(userID);
        }

        public void BanMember(string ipAddress, long timeTicks) 
        {
            this.m_memberDAL.BanMember(ipAddress, timeTicks);
        }

        public bool IsMemberBanned(string ipAddress, string time) 
        {
            return this.m_memberDAL.IsMemberBanned(ipAddress, time);
        }   

        public void LoggingAction(int userID, string action) 
        {
            this.m_loggingDAL.LoggingAction(userID, action);
        }

        public Member GetUserUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Member GetUserPassword(string username)
        {
            throw new NotImplementedException();
        }

        public List<Thread> GetThreadsByUsername(string username)
        {
            return this.m_threadDAL.GetThreadsByUsername(username);
        }

    }
}

