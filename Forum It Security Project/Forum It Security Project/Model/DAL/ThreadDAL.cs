using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum_It_Security_Project.Model.DAL
{
    public class ThreadDAL
    {
        public void CreateThread(Thread thread)
        {
            throw new NotImplementedException();
        }

        internal Thread GetThreadByID(int threadID)
        {
            throw new NotImplementedException();
        }

        internal void DeleteThread(int threadID)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByThreadID(int threadID)
        {
            throw new NotImplementedException();
        }

        internal List<Thread> GetThreads()
        {
            throw new NotImplementedException();
        }

        internal List<Thread> GetThreadsByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void PostComment(int threadID, int userID, string comment)
        {
            throw new NotImplementedException();
        }
    }
}